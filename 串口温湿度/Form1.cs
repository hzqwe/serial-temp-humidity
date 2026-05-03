using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports; // 串口通信核心命名空间，提供SerialPort类
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers; // 系统计时器命名空间（后台线程计时器）
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace 串口温湿度
{
    // 主窗体类：包含整个串口助手的所有逻辑（UI交互+串口通信+数据解析+容错）
    public partial class Form1 : Form
    {
        #region 全局变量定义（按功能分类，便于理解）
        // 串口核心对象：负责与硬件（如温湿度传感器）建立串口通信连接
        private SerialPort serialPort = new SerialPort();

        // WinForm计时器：用于定时自动发送数据（运行在UI线程，可直接操作控件）
        private System.Windows.Forms.Timer sendTimer = new System.Windows.Forms.Timer();

        // 断线重连计时器：串口报错后，定时尝试重新连接（后台线程计时器）
        private System.Timers.Timer _reconnectTimer;

        // 串口连接状态标记：比serialPort.IsOpen更可靠，标记"实际通信是否正常"
        private bool _isSerialConnected = false;

        // 重连间隔常量：每次重连的时间间隔（2000ms=2秒），避免高频重连占用资源
        private const int ReconnectIntervalMs = 2000;

        // 最大重连次数常量：限制断线后重连的次数（工业常用5次）
        private const int MaxReconnectCount = 5;

        // 重连次数计数器：记录当前已重连的次数
        private int _currentReconnectCount = 0;
        #endregion

        #region 构造函数（窗体初始化）
        // 窗体构造函数：创建窗体时自动执行，初始化核心资源
        public Form1()
        {
            // WinForm必备：自动初始化窗体上的所有控件（按钮、下拉框、文本框等）
            InitializeComponent();
            // 调用自定义的串口初始化方法，配置默认参数和计时器
            InitSerialPort();
        }
        #endregion

        #region 串口开关核心逻辑（按钮点击事件）
        // 打开/关闭串口按钮点击事件：一个按钮实现两种功能，逻辑分离更可靠
        private async void button_OpenSerial_Click(object sender, EventArgs e)
        {
            try
            {
                // ========== 纯关闭逻辑 ==========
                // 条件：串口已打开 且 按钮显示"关闭串口" → 仅执行关闭操作，不碰其他逻辑
                if (serialPort.IsOpen && button_OpenSerial.Text == "关闭串口")
                {
                    CloseSerialPort(); // 调用封装的关闭串口方法
                    return; // 关闭后直接返回，避免执行后续的打开逻辑
                }

                // ========== 纯打开逻辑 ==========
                // 条件：串口未打开 且 按钮显示"打开串口" → 仅执行打开操作
                if (!serialPort.IsOpen && button_OpenSerial.Text == "打开串口")
                {
                    // 1. 校验串口参数是否选择（逐一下拉框校验，避免参数缺失）
                    if (comboBox_SerialPort.SelectedItem == null)
                    {
                        AppendLog("请选择串口号！");
                        return;
                    }
                    if (comboBox_BaudRate.SelectedItem == null)
                    {
                        AppendLog("请选择波特率！");
                        return;
                    }
                    if (comboBox_DataBits.SelectedItem == null)
                    {
                        AppendLog("请选择数据位！");
                        return;
                    }
                    if (comboBox_Parity.SelectedItem == null)
                    {
                        AppendLog("请选择校验位！");
                        return;
                    }
                    if (comboBox_StopBits.SelectedItem == null)
                    {
                        AppendLog("请选择停止位！");
                        return;
                    }

                    // 2. 配置串口核心参数（必须与硬件设备参数一致，否则通信失败）
                    serialPort.PortName = comboBox_SerialPort.SelectedItem.ToString(); // 串口名（如COM3）
                    serialPort.BaudRate = int.Parse(comboBox_BaudRate.SelectedItem.ToString()); // 波特率（通信速率）
                    serialPort.DataBits = int.Parse(comboBox_DataBits.SelectedItem.ToString()); // 数据位（每个字节的长度）
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Parity.SelectedItem.ToString()); // 校验位
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_StopBits.SelectedItem.ToString()); // 停止位
                    serialPort.Encoding = Encoding.UTF8; // 字符编码（字符串与字节转换规则）

                    serialPort.NewLine = "\n";

                    // 3. 打开串口（核心操作，失败会抛出异常）
                    serialPort.Open();
                    serialPort.ReadTimeout = 500; // 500毫秒足够接收一行，避免无限阻塞

                    serialPort.DiscardInBuffer();  // 清空上电瞬间的噪音数据
                    serialPort.DiscardOutBuffer();

                    AppendLog("串口已打开，等待传感器初始化...");
                    // 等待NodeMCU启动 + DHT11初始化完成（保守2秒）
                    await Task.Delay(2000);

                    serialPort.DiscardInBuffer();   // ★ 延时结束再清空一次，丢弃启动信息

                    // 4. 初始化串口连接状态
                    _isSerialConnected = true; // 标记连接成功
                    _currentReconnectCount = 0; // 重置重连次数
                    sendTimer.Start(); // 启动定时发送计时器

                    // 5. 绑定串口事件（数据接收/错误捕获）
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler); // 数据接收事件
                    serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(ErrorReceivedHandler); // 串口错误事件

                    // 6. UI反馈与首次发送
                    AppendLog($"成功打开串口：{serialPort.PortName}");
                    button_OpenSerial.Text = "关闭串口"; // 按钮文字切换
                }
            }
            catch (Exception ex)
            {
                // 捕获所有异常（如串口被占用、参数错误），避免程序崩溃
                AppendLog($"操作串口失败：{ex.Message}");
            }
        }
        #endregion


        #region 串口关闭与资源释放
        // 封装的串口关闭方法：彻底释放所有资源，避免内存泄漏/线程残留
        private void CloseSerialPort()
        {
            // 前置校验：串口对象不为空才执行关闭逻辑
            if (serialPort == null) return;

            // 1. 停止所有计时器（核心：避免计时器后台运行）
            sendTimer.Stop(); // 停止定时发送计时器

            // 3. 销毁断线重连计时器（完整释放流程）
            if (_reconnectTimer != null)
            {
                _reconnectTimer.Elapsed -= OnReconnectElapsed; // 移除事件绑定
                _reconnectTimer.Stop();
                _reconnectTimer.Dispose();
                _reconnectTimer = null; // 置空引用
            }

            // 4. 解绑串口事件（避免事件残留导致内存泄漏）
            serialPort.DataReceived -= DataReceivedHandler;
            serialPort.ErrorReceived -= ErrorReceivedHandler;

            // 5. 关闭串口（核心：释放硬件资源）
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    AppendLog($"关闭串口失败：{ex.Message}");
                }
            }

            // 6. 重置所有状态变量（避免下次打开串口时状态混乱）
            _isSerialConnected = false;    // 标记连接断开
            _currentReconnectCount = 0;    // 重置重连次数

            // 7. UI反馈
            AppendLog("串口已关闭（所有任务已停止）");
            button_OpenSerial.Text = "打开串口";
        }
        #endregion

        #region 断线重连核心逻辑
        // 串口错误捕获事件：串口通信出错时触发（如帧错误、溢出错误）
        private void ErrorReceivedHandler(object sender, SerialErrorReceivedEventArgs e)
        {
            // 1. 日志记录错误类型（便于调试定位问题）
            AppendLog($"[串口错误] 类型：{e.EventType}");

            // 2. 判定断线类型：仅处理严重错误（帧错误/溢出错误/接收缓冲区溢出）
            if (e.EventType == SerialError.Frame || e.EventType == SerialError.Overrun || e.EventType == SerialError.RXOver)
            {
                _isSerialConnected = false; // 标记连接断开
                _reconnectTimer.Enabled = true; // 启动断线重连计时器
                AppendLog("【断线检测】串口报错，启动自动重连...");
            }
        }

        // 断线重连计时器触发事件：定时尝试重新连接串口
        private void OnReconnectElapsed(object sender, ElapsedEventArgs e)
        {
            // 跨线程操作UI：后台线程计时器需Invoke切换到UI线程
            this.Invoke(new Action(() =>
            {
                // 1. 校验重连终止条件
                if (_isSerialConnected) // 已重新连接成功 → 停止重连
                {
                    _reconnectTimer.Enabled = false;
                    AppendLog("【断线重连】已恢复连接，停止重连");
                    return;
                }
                if (_currentReconnectCount >= MaxReconnectCount) // 达到最大重连次数 → 停止重连
                {
                    _reconnectTimer.Enabled = false;
                    AppendLog($"【断线重连】重连{MaxReconnectCount}次失败，停止尝试");
                    return;
                }

                // 2. 重连次数+1
                _currentReconnectCount++;
                AppendLog($"【断线重连】第{_currentReconnectCount}次尝试重连...");

                try
                {
                    // 3. 复用当前选择的串口参数（无需重新选择）
                    serialPort.PortName = comboBox_SerialPort.SelectedItem?.ToString() ?? "";
                    serialPort.BaudRate = int.TryParse(comboBox_BaudRate.SelectedItem?.ToString(), out int baud) ? baud : 9600;
                    serialPort.DataBits = int.TryParse(comboBox_DataBits.SelectedItem?.ToString(), out int data) ? data : 8;
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Parity.SelectedItem?.ToString() ?? "None");
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_StopBits.SelectedItem?.ToString() ?? "One");

                    // 4. 尝试打开串口
                    serialPort.Open();

                    // 5. 重连成功：恢复状态+绑定事件+启动定时发送
                    _isSerialConnected = true;
                    _reconnectTimer.Enabled = false;
                    serialPort.DataReceived += DataReceivedHandler;
                    serialPort.ErrorReceived += ErrorReceivedHandler;
                    sendTimer.Start();

                    // 6. UI反馈
                    AppendLog($"【断线重连】第{_currentReconnectCount}次重连成功！");
                    button_OpenSerial.Text = "关闭串口";
                }
                catch (Exception ex)
                {
                    // 重连失败：记录日志，等待下一次重连
                    AppendLog($"【断线重连】第{_currentReconnectCount}次重连失败：{ex.Message}");
                }
            }));
        }
        #endregion

        #region 数据接收与解析核心逻辑
        // 串口数据接收事件：串口有数据传入时自动触发（运行在串口线程）
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            try
            {
                while (sp.BytesToRead > 0)
                {
                    string line;
                    try
                    {
                        line = sp.ReadLine();
                    }
                    catch (TimeoutException)
                    {
                        // 超时意味着暂时没有完整的行，退出循环等待下次事件
                        break;
                    }
                    catch (IOException)
                    {
                        // 串口正在关闭，读取被中止，正常退出
                        break;
                    }

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    if (!line.Contains(".") || line.Contains("ERROR"))
                        continue;

                    ProcessCompleteLine(line);
                }
            }
            catch (Exception ex)
            {
                AppendLog($"接收数据异常：{ex.Message}");
            }
        }

        // 粘包/半包处理方法：将零散数据拼接为完整的8字节帧
        private void ProcessCompleteLine(string line)
        {
            try
            {
                // 按“|”分割温度和湿度两部分
                string[] parts = line.Split('|');
                if (parts.Length < 2) return;

                // 处理温度部分：“🌡 温度: 28.5 ℃”
                string tempPart = parts[0];
                int tempStart = tempPart.IndexOf(':'); // 找到冒号位置
                if (tempStart == -1) return;
                string tempStr = tempPart.Substring(tempStart + 1).Trim(); // 取冒号后面的内容
                tempStr = tempStr.Replace("℃", "").Trim(); // 去掉 ℃ 符号

                // 处理湿度部分：“  湿度: 69.0 %”
                string humiPart = parts[1];
                int humiStart = humiPart.IndexOf(':');
                if (humiStart == -1) return;
                string humiStr = humiPart.Substring(humiStart + 1).Trim();
                humiStr = humiStr.Replace("%", "").Trim(); // 去掉 % 符号

                if (float.TryParse(tempStr, out float temp) && float.TryParse(humiStr, out float humi))
                {
                    // 过滤明显错误的值
                    if (temp > -20 && temp < 60 && humi >= 0 && humi <= 100)
                    {
                        AppendLog($"温度：{temp:F1} °C, 湿度：{humi:F1} %");
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog($"解析温湿度数据失败：{ex.Message}");
            }
        }

        #endregion

        #region 初始化与辅助方法
        // 串口与计时器初始化：配置默认参数和下拉框选项
        private void InitSerialPort()
        {
            // 1. 初始化定时发送计时器
            sendTimer.Interval = 2000; // 定时间隔：2000ms=2秒

            // 2. 填充串口下拉框（自动检测电脑可用串口）
            string[] ports = SerialPort.GetPortNames();
            textBox_Send.Text = ""; // 默认发送指令
            foreach (string port in ports)
            {
                comboBox_SerialPort.Items.Add(port);
            }
            if (ports.Length > 0)
            {
                comboBox_SerialPort.SelectedIndex = 0; // 默认选中第一个串口
            }

            // 3. 填充波特率下拉框（工业常用波特率）
            List<string> baudRates = new List<string> { "4800", "9600", "19200", "38400", "115200" };
            foreach (string rate in baudRates)
            {
                comboBox_BaudRate.Items.Add(rate);
            }
            comboBox_BaudRate.SelectedIndex = 1; // 默认选中9600

            // 4. 填充数据位下拉框
            List<string> dataBits = new List<string> { "5", "6", "7", "8" };
            foreach (string bits in dataBits)
            {
                comboBox_DataBits.Items.Add(bits);
            }
            comboBox_DataBits.SelectedIndex = 3; // 默认选中8

            // 5. 填充校验位下拉框
            List<string> parity = new List<string> { "None", "Odd", "Even", "Mark", "Space" };
            foreach (string p in parity)
            {
                comboBox_Parity.Items.Add(p);
            }
            comboBox_Parity.SelectedIndex = 0; // 默认选中None（无校验）

            // 6. 填充停止位下拉框
            List<string> stopBits = new List<string> { "1", "1.5", "2" };
            foreach (string bits in stopBits)
            {
                comboBox_StopBits.Items.Add(bits);
            }
            comboBox_StopBits.SelectedIndex = 0; // 默认选中1

            // 7. 初始化断线重连计时器
            _reconnectTimer = new System.Timers.Timer(ReconnectIntervalMs);
            _reconnectTimer.Elapsed += OnReconnectElapsed; // 绑定重连事件
            _reconnectTimer.AutoReset = true; // 循环触发（直到重连成功/达到最大次数）
            _reconnectTimer.Enabled = false; // 初始禁用（串口报错后启用）
        }

        // 手动发送按钮点击事件：触发发送文本框中的指令
        private void button_SendData_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    SendData(textBox_Send.Text);
                }
                else
                {
                    AppendLog("请先打开串口！");
                    return;
                }
            }
            catch (Exception ex)
            {
                AppendLog($"发送数据失败：{ex.Message}");
            }
        }

        // 基础发送方法：将字符串转换为固定8字节格式，调用超时重发方法
        private void SendData(string text)
        {
            // 前置校验：指令为空则提示
            if (string.IsNullOrWhiteSpace(text))
            {
                AppendLog("输入的指令不能为空！");
                return;
            }

            // 固定8字节格式处理：不足8位补空格，超过8位截断（工业常用固定长度帧）
            string fixed8ByteData = text.PadRight(8).Substring(0, 8);

            try
            {
                if (serialPort.IsOpen)
                {
                    // 转换字符串为字节数组（串口底层传输的是字节，而非字符串）
                    byte[] sendBytes = Encoding.UTF8.GetBytes(fixed8ByteData);
                    serialPort.Write(sendBytes, 0, sendBytes.Length);
                }
                else
                {
                    AppendLog("串口未打开，发送失败！");
                }
            }
            catch (Exception ex)
            {
                AppendLog($"发送失败：{ex.Message}");
            }
        }

        // 跨线程日志输出方法：解决WinForm跨线程访问UI控件异常
        // 串口线程/计时器线程不能直接操作UI，需通过Invoke切换到UI线程
        private void AppendLog(string data)
        {
            // InvokeRequired：判断当前线程是否为UI线程
            if (RichTextBox_Received.InvokeRequired)
            {
                // 非UI线程：委托UI线程执行AppendLog方法
                RichTextBox_Received.BeginInvoke(new Action<string>(AppendLog), data);
                return;
            }

            // 判断用户当前是否在查看末尾
            bool isAtEnd = RichTextBox_Received.GetPositionFromCharIndex(RichTextBox_Received.TextLength).Y
                           < RichTextBox_Received.ClientSize.Height + 10;

            RichTextBox_Received.AppendText($"{data}{Environment.NewLine}");

            // 只有在用户没有手动翻看历史日志时，才跟随滚动
            if (isAtEnd)
            {
                RichTextBox_Received.ScrollToCaret();
            }
        }

        // 窗体关闭事件：程序退出时彻底释放所有资源
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // 1. 关闭串口并解绑事件
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                    serialPort.DiscardInBuffer(); // 清空接收缓冲区
                    serialPort.DataReceived -= DataReceivedHandler;
                    serialPort.ErrorReceived -= ErrorReceivedHandler;
                }
            }
            catch (Exception ex)
            {
                AppendLog($"关闭串口失败：{ex.Message}");
            }

            // 2. 释放所有计时器资源
            _reconnectTimer?.Stop();
            _reconnectTimer?.Dispose();
            sendTimer.Dispose();

            // 3. 释放串口对象
            serialPort.Dispose();
        }
        #endregion

    }
}