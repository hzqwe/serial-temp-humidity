Project Path: 串口温湿度

Source Tree:

```txt
串口温湿度
├── App.config
├── Form1.Designer.cs
├── Form1.cs
├── Form1.resx
├── Program.cs
├── Properties
│   ├── AssemblyInfo.cs
│   ├── Resources.Designer.cs
│   ├── Resources.resx
│   └── Settings.Designer.cs
└── 串口温湿度.csproj

```

`App.config`:

```config
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
    </startup>
</configuration>
```

`Form1.Designer.cs`:

```cs
namespace 串口温湿度
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OpenSerial = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_SendData = new System.Windows.Forms.Button();
            this.textBox_Receive = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OpenSerial
            // 
            this.button_OpenSerial.Location = new System.Drawing.Point(44, 645);
            this.button_OpenSerial.Name = "button_OpenSerial";
            this.button_OpenSerial.Size = new System.Drawing.Size(398, 65);
            this.button_OpenSerial.TabIndex = 12;
            this.button_OpenSerial.Text = "打开串口";
            this.button_OpenSerial.UseVisualStyleBackColor = true;
            this.button_OpenSerial.Click += new System.EventHandler(this.button_OpenSerial_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(257, 517);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 22);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "16进制";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 517);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 22);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "字符串";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox_StopBits
            // 
            this.comboBox_StopBits.FormattingEnabled = true;
            this.comboBox_StopBits.Location = new System.Drawing.Point(163, 412);
            this.comboBox_StopBits.Name = "comboBox_StopBits";
            this.comboBox_StopBits.Size = new System.Drawing.Size(202, 26);
            this.comboBox_StopBits.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "停止位";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Location = new System.Drawing.Point(163, 319);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(202, 26);
            this.comboBox_Parity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "校验位";
            // 
            // comboBox_DataBits
            // 
            this.comboBox_DataBits.FormattingEnabled = true;
            this.comboBox_DataBits.Location = new System.Drawing.Point(163, 231);
            this.comboBox_DataBits.Name = "comboBox_DataBits";
            this.comboBox_DataBits.Size = new System.Drawing.Size(202, 26);
            this.comboBox_DataBits.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据位";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(163, 144);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(202, 26);
            this.comboBox_BaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // comboBox_SerialPort
            // 
            this.comboBox_SerialPort.FormattingEnabled = true;
            this.comboBox_SerialPort.Location = new System.Drawing.Point(163, 63);
            this.comboBox_SerialPort.Name = "comboBox_SerialPort";
            this.comboBox_SerialPort.Size = new System.Drawing.Size(202, 26);
            this.comboBox_SerialPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(33, 50);
            this.textBox_Send.Multiline = true;
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(592, 301);
            this.textBox_Send.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Send);
            this.groupBox2.Location = new System.Drawing.Point(662, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 420);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送数据";
            // 
            // button_SendData
            // 
            this.button_SendData.Location = new System.Drawing.Point(33, 348);
            this.button_SendData.Name = "button_SendData";
            this.button_SendData.Size = new System.Drawing.Size(592, 47);
            this.button_SendData.TabIndex = 3;
            this.button_SendData.Text = "发送数据";
            this.button_SendData.UseVisualStyleBackColor = true;
            this.button_SendData.Click += new System.EventHandler(this.button_SendData_Click);
            // 
            // textBox_Receive
            // 
            this.textBox_Receive.Location = new System.Drawing.Point(33, 27);
            this.textBox_Receive.Multiline = true;
            this.textBox_Receive.Name = "textBox_Receive";
            this.textBox_Receive.Size = new System.Drawing.Size(592, 301);
            this.textBox_Receive.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_SendData);
            this.groupBox3.Controls.Add(this.textBox_Receive);
            this.groupBox3.Location = new System.Drawing.Point(662, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 420);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收数据";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OpenSerial);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.comboBox_StopBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_Parity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_DataBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_SerialPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 779);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 918);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenSerial;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_DataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_SerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_SendData;
        private System.Windows.Forms.TextBox textBox_Receive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


```

`Form1.cs`:

```cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        // 全局接收缓冲区：解决串口"粘包/半包"问题，临时存储所有接收的字节数据
        // 粘包：多个数据帧连在一起接收；半包：一个数据帧只接收了一部分
        private byte[] _receiveBuffer = new byte[1024];

        // 缓冲区索引：标记当前接收的数据存到了缓冲区的哪个位置（数据指针）
        private int _bufferIndex = 0;

        // WinForm计时器：用于定时自动发送数据（运行在UI线程，可直接操作控件）
        private System.Windows.Forms.Timer sendTimer = new System.Windows.Forms.Timer();

        // 超时重发计时器：用于检测"发送数据后无响应"，触发自动重发（后台线程计时器）
        private System.Timers.Timer _timeoutTimer;

        // 重发次数计数器：记录当前数据已重发的次数，防止无限重发
        private int _retryCount = 0;

        // 最大重发次数常量：限制重发次数（工业常用3次，避免无效重试）
        private const int MaxRetryCount = 3;

        // 缓存最后一次发送的字节数据：超时重发时复用该数据，无需重新拼接
        private byte[] _lastSentData;

        // 超时时间常量：发送数据后等待响应的时间（500ms），超时则触发重发
        private const int TimeoutMs = 500;

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
        private void button_OpenSerial_Click(object sender, EventArgs e)
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

                    // 3. 打开串口（核心操作，失败会抛出异常）
                    serialPort.Open();

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
                    SendData(textBox_Send.Text); // 打开串口后立即发送一次默认指令
                }
            }
            catch (Exception ex)
            {
                // 捕获所有异常（如串口被占用、参数错误），避免程序崩溃
                AppendLog($"操作串口失败：{ex.Message}");
            }
        }
        #endregion

        #region 超时重发核心逻辑
        // 带超时重发的发送方法：发送数据+启动超时计时器，超时自动重发
        // 参数：要发送的字节数组（串口底层以字节传输，而非字符串）
        public void SendDataWithTimeout(byte[] data)
        {
            // 1. 校验是否达到最大重发次数，达到则停止重发
            if (_retryCount >= MaxRetryCount)
            {
                AppendLog($"【超时重发】达到最大重发次数（{MaxRetryCount}次），停止发送");
                return;
            }

            // 2. 缓存本次发送的数据（用于超时后重发）
            _lastSentData = data.Clone() as byte[];

            // 3. 核心操作：通过串口发送字节数据
            serialPort.Write(data, 0, data.Length);

            // 4. 释放旧的超时计时器（关键：避免多个计时器同时运行）
            _timeoutTimer?.Stop();    // 停止计时器
            _timeoutTimer?.Dispose(); // 释放计时器资源

            // 5. 初始化新的超时计时器
            _timeoutTimer = new System.Timers.Timer(TimeoutMs); // 设置超时时间
            _timeoutTimer.Elapsed += OnTimeoutElapsed; // 绑定超时触发事件
            _timeoutTimer.AutoReset = false; // 仅触发一次（避免重复重发）
            _timeoutTimer.Start(); // 启动计时器

            // 6. 日志记录：便于调试查看发送次数和内容
            AppendLog($"【发送指令】第{_retryCount + 1}次发送：{Encoding.UTF8.GetString(data)}");
        }

        // 超时计时器触发事件：发送数据后超时无响应，执行重发逻辑
        private void OnTimeoutElapsed(object sender, ElapsedEventArgs e)
        {
            // 前置校验：串口未打开则直接返回（避免空操作）
            if (!serialPort.IsOpen) return;

            // 跨线程操作UI：System.Timers.Timer运行在后台线程，需Invoke切换到UI线程
            this.Invoke(new Action(() =>
            {
                // 二次校验：防止Invoke过程中串口被关闭
                if (!serialPort.IsOpen) return;

                // 1. 日志记录超时信息
                AppendLog($"【超时重发】通信超时（{TimeoutMs}ms），第{_retryCount + 1}次重发");

                // 2. 重发次数+1
                _retryCount++;

                // 3. 校验缓存数据是否存在，存在则调用重发方法
                if (_lastSentData != null)
                {
                    SendDataWithTimeout(_lastSentData);
                }
            }));
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

            // 2. 销毁超时重发计时器（完整释放流程）
            if (_timeoutTimer != null)
            {
                _timeoutTimer.Elapsed -= OnTimeoutElapsed; // 移除事件绑定（关键）
                _timeoutTimer.Stop();
                _timeoutTimer.Dispose();
                _timeoutTimer = null; // 置空引用，便于GC回收
            }

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
            _retryCount = 0;               // 重置重发次数
            _currentReconnectCount = 0;    // 重置重连次数
            _lastSentData = null;          // 清空缓存的发送数据

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
            // 转换为SerialPort对象，便于操作
            SerialPort sp = (SerialPort)sender;

            try
            {
                // 关键：收到数据立即停止超时计时器，重置重发次数（表示通信正常）
                _timeoutTimer?.Stop();
                _retryCount = 0;

                // 1. 获取串口缓冲区中待读取的字节数
                int bytesToRead = sp.BytesToRead;
                if (bytesToRead <= 0) // 无数据则直接返回
                {
                    AppendLog("没有接收到数据");
                    return;
                }

                // 2. 读取串口数据到临时缓冲区
                byte[] buffer = new byte[bytesToRead];
                int readLength = sp.Read(buffer, 0, bytesToRead); // 实际读取的字节数

                // 3. 转换为字符串（便于初步判断数据类型）
                string receivedStr = Encoding.UTF8.GetString(buffer, 0, readLength);

                // 4. 过滤非数据帧（避免无效解析）
                // 过滤条件：① 等于发送的指令 ② 不含小数点（非温湿度数据） ③ 包含ERROR（错误数据）
                if (receivedStr == textBox_Send.Text || !receivedStr.Contains(".") || receivedStr.Contains("ERROR"))
                {
                    AppendLog($"「【接收 - 非数据帧】{receivedStr}」");
                    return;
                }

                // 5. 有效数据帧：记录日志+调用粘包处理方法
                AppendLog($"「【接收 - 原始数据】{receivedStr}」");
                ProcessedRecievedData(buffer, readLength);
            }
            catch (Exception ex)
            {
                // 捕获读取数据异常（如串口突然断开），避免程序崩溃
                AppendLog($"接收数据失败：{ex.Message}");
            }
        }

        // 粘包/半包处理方法：将零散数据拼接为完整的8字节帧
        private void ProcessedRecievedData(byte[] data, int length)
        {
            //加锁的作用是保证线程安全
            lock (_receiveBuffer)
            {

                //Array.Copy(源数组, 源起始索引, 目标数组, 目标起始索引, 复制长度);

                //从哪拿，从哪开始拿；放到哪，从哪开始放；拿多少

                //参数位置 参数名 含义 举例（结合你的代码）
                //  1   sourceArray 从哪个数组拷贝数据   data（本次收到的字节数组）
                //  2   sourceIndex 从源数组的第几个元素开始拷贝  length - _receiveBuffer.Length（只保留最后 1024 字节）
                //  3   destinationArray 拷贝到哪个数组 _receiveBuffer（全局缓冲区）
                //  4   destinationIndex 放到目标数组的第几个位置    0（从缓冲区开头放）
                //  5   length 拷贝多少个元素 _receiveBuffer.Length（拷贝 1024 字节）
                try
                {
                    // ===== 1. 边界保护：防止单次接收数据超过缓冲区总容量 =====
                    if (length > _receiveBuffer.Length)
                    {
                        //“比如传来1028个，然后丢弃了前4个，保留了后1024个，把它们移到索引的开头。”
                        // 截断保留最后 _receiveBuffer.Length 字节，避免越界
                        Array.Copy(data, length - _receiveBuffer.Length, _receiveBuffer, 0, _receiveBuffer.Length);
                        _bufferIndex = _receiveBuffer.Length;
                    }
                    else
                    {
                        // ===== 2. 累积溢出保护：若新数据会导致越界，清空缓冲区 =====
                        if (_bufferIndex + length > _receiveBuffer.Length)
                        {
                            _bufferIndex = 0;
                            AppendLog("缓冲区溢出，已清空");
                        }

                        // ===== 3. 将新数据追加到缓冲区 =====
                        for (int i = 0; i < length; i++)
                        {
                            _receiveBuffer[_bufferIndex++] = data[i];
                        }
                    }

                    // ===== 4. 帧同步与提取（解决粘包/半包） =====
                    while (_bufferIndex >= 8)
                    {
                        byte firstByte = _receiveBuffer[0];

                        // 帧头校验：首字节必须是数字 '0'~'9' 或负号 '-'（温湿度帧特征）
                        bool isValidHeader = (firstByte >= 0x30 && firstByte <= 0x39) || firstByte == 0x2D;

                        if (!isValidHeader)
                        {
                            // 无效帧头：丢弃首字节，数据整体左移一位，继续寻找有效帧头
                            Array.Copy(_receiveBuffer, 1, _receiveBuffer, 0, _bufferIndex - 1);
                            _bufferIndex--;
                            continue;
                        }

                        // 提取一个完整帧（8字节），复制出来避免移位时影响解析
                        byte[] frame = new byte[8];
                        Array.Copy(_receiveBuffer, 0, frame, 0, 8);
                        ProcessCompleteFrame(frame, 8);

                        // 移除已处理的 8 字节，剩余数据前移
                        int remainLength = _bufferIndex - 8;
                        if (remainLength > 0)
                        {
                            Array.Copy(_receiveBuffer, 8, _receiveBuffer, 0, remainLength);
                        }
                        _bufferIndex = remainLength;
                    }
                }
                catch (Exception ex)
                {
                    AppendLog($"处理接收数据失败：{ex.Message}");
                    _bufferIndex = 0;   // 异常后重置缓冲区，避免状态错乱
                }
            }
        }

        // 解析8字节温湿度完整帧：转换为易读的温度/湿度格式
        private void ProcessCompleteFrame(byte[] frame, int length)
        {
            // 1. 转换为16进制字符串（便于调试查看原始字节数据）
            string hexStr = BitConverter.ToString(frame, 0, length).Replace("-", " ");

            // 2. 转换为UTF8文本字符串（去除首尾空格）
            string textStr = Encoding.UTF8.GetString(frame, 0, length).Trim();

            // 3. 记录原始帧日志
            AppendLog($"[完整帧] 16进制：{hexStr}");

            // 4. 再次过滤非数据帧（双重校验，避免解析错误）
            if (textStr == textBox_Send.Text || !textStr.Contains(".") || textStr.Contains("ERROR"))
            {
                AppendLog("非数据帧，跳过处理");
                return;
            }

            try
            {
                // 5. 拆分温湿度数据（核心解析逻辑）
                int dotIndex = textStr.IndexOf('.'); // 查找小数点位置（拆分温度/湿度的关键）
                // 校验数据格式有效性：① 非空 ② 包含小数点 ③ 小数点后至少2位 ④ 总长度8位 ⑤ 无错误标识
                if (!string.IsNullOrEmpty(textStr) && textStr.Contains(".") && dotIndex + 2 < textStr.Length && textStr.Length == 8 && !textStr.Contains("ERROR"))
                {
                    if (dotIndex > 0) // 小数点不在首位（避免无效数据）
                    {
                        // 拆分温度字符串（包含小数点后1位，如"25.5"）
                        string TempStr = textStr.Substring(0, dotIndex + 2);
                        // 拆分湿度字符串（小数点后2位，如"60"）
                        string HumiStr = textStr.Substring(dotIndex + 2, 2);

                        // 转换为数值类型（TryParse避免转换失败崩溃）
                        if (float.TryParse(TempStr, out float Temp) && float.TryParse(HumiStr, out float Humi))
                        {
                            // 过滤合理的温湿度范围（工业常用：温度-20~60℃，湿度0~100%）
                            if (Temp >= -20 && Temp <= 60 && Humi >= 0 && Humi <= 100)
                            {
                                AppendLog($"温度：{Temp} °C, 湿度：{Humi} %");
                            }
                            else
                            {
                                AppendLog("温度或湿度值超出合理范围");
                            }
                        }
                        else
                        {
                            AppendLog("无法解析温度或湿度值（格式错误）");
                        }
                    }
                    else
                    {
                        AppendLog("数据格式错误（小数点在首位）");
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog($"解析温湿度数据失败：{ex.Message}");
            }

            // 记录解析后的文本帧日志
            AppendLog($"[完整帧] 文本：{textStr}");
        }
        #endregion

        #region 初始化与辅助方法
        // 串口与计时器初始化：配置默认参数和下拉框选项
        private void InitSerialPort()
        {
            // 1. 初始化定时发送计时器
            sendTimer.Interval = 2000; // 定时间隔：2000ms=2秒
            // 定时器触发事件：串口打开时自动发送文本框中的指令
            sendTimer.Tick += (s, e) =>
            {
                if (serialPort.IsOpen)
                {
                    SendData(textBox_Send.Text);
                }
            };

            // 2. 填充串口下拉框（自动检测电脑可用串口）
            string[] ports = SerialPort.GetPortNames();
            textBox_Send.Text = "GetData"; // 默认发送指令
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
                    // 调用带超时重发的发送方法
                    SendDataWithTimeout(sendBytes);
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
            if (textBox_Receive.InvokeRequired)
            {
                // 非UI线程：委托UI线程执行AppendLog方法
                textBox_Receive.Invoke(new Action<string>(AppendLog), data);
            }
            else
            {
                // UI线程：直接更新文本框，追加日志并自动滚动到最新行
                textBox_Receive.AppendText($"{data}{Environment.NewLine}");
                textBox_Receive.ScrollToCaret();
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
            _timeoutTimer?.Stop();
            _timeoutTimer?.Dispose();
            _reconnectTimer?.Stop();
            _reconnectTimer?.Dispose();
            sendTimer.Dispose();

            // 3. 释放串口对象
            serialPort.Dispose();
        }
        #endregion

    }
}
```

`Form1.resx`:

```resx
<?xml version="1.0" encoding="utf-8"?>
<root>
  <!-- 
    Microsoft ResX Schema 
    
    Version 2.0
    
    The primary goals of this format is to allow a simple XML format 
    that is mostly human readable. The generation and parsing of the 
    various data types are done through the TypeConverter classes 
    associated with the data types.
    
    Example:
    
    ... ado.net/XML headers & schema ...
    <resheader name="resmimetype">text/microsoft-resx</resheader>
    <resheader name="version">2.0</resheader>
    <resheader name="reader">System.Resources.ResXResourceReader, System.Windows.Forms, ...</resheader>
    <resheader name="writer">System.Resources.ResXResourceWriter, System.Windows.Forms, ...</resheader>
    <data name="Name1"><value>this is my long string</value><comment>this is a comment</comment></data>
    <data name="Color1" type="System.Drawing.Color, System.Drawing">Blue</data>
    <data name="Bitmap1" mimetype="application/x-microsoft.net.object.binary.base64">
        <value>[base64 mime encoded serialized .NET Framework object]</value>
    </data>
    <data name="Icon1" type="System.Drawing.Icon, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
        <value>[base64 mime encoded string representing a byte array form of the .NET Framework object]</value>
        <comment>This is a comment</comment>
    </data>
                
    There are any number of "resheader" rows that contain simple 
    name/value pairs.
    
    Each data row contains a name, and value. The row also contains a 
    type or mimetype. Type corresponds to a .NET class that support 
    text/value conversion through the TypeConverter architecture. 
    Classes that don't support this are serialized and stored with the 
    mimetype set.
    
    The mimetype is used for serialized objects, and tells the 
    ResXResourceReader how to depersist the object. This is currently not 
    extensible. For a given mimetype the value must be set accordingly:
    
    Note - application/x-microsoft.net.object.binary.base64 is the format 
    that the ResXResourceWriter will generate, however the reader can 
    read any of the formats listed below.
    
    mimetype: application/x-microsoft.net.object.binary.base64
    value   : The object must be serialized with 
            : System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
            : and then encoded with base64 encoding.
    
    mimetype: application/x-microsoft.net.object.soap.base64
    value   : The object must be serialized with 
            : System.Runtime.Serialization.Formatters.Soap.SoapFormatter
            : and then encoded with base64 encoding.

    mimetype: application/x-microsoft.net.object.bytearray.base64
    value   : The object must be serialized into a byte array 
            : using a System.ComponentModel.TypeConverter
            : and then encoded with base64 encoding.
    -->
  <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
    <xsd:import namespace="http://www.w3.org/XML/1998/namespace" />
    <xsd:element name="root" msdata:IsDataSet="true">
      <xsd:complexType>
        <xsd:choice maxOccurs="unbounded">
          <xsd:element name="metadata">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" />
              </xsd:sequence>
              <xsd:attribute name="name" use="required" type="xsd:string" />
              <xsd:attribute name="type" type="xsd:string" />
              <xsd:attribute name="mimetype" type="xsd:string" />
              <xsd:attribute ref="xml:space" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="assembly">
            <xsd:complexType>
              <xsd:attribute name="alias" type="xsd:string" />
              <xsd:attribute name="name" type="xsd:string" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="data">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
                <xsd:element name="comment" type="xsd:string" minOccurs="0" msdata:Ordinal="2" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" use="required" msdata:Ordinal="1" />
              <xsd:attribute name="type" type="xsd:string" msdata:Ordinal="3" />
              <xsd:attribute name="mimetype" type="xsd:string" msdata:Ordinal="4" />
              <xsd:attribute ref="xml:space" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="resheader">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" use="required" />
            </xsd:complexType>
          </xsd:element>
        </xsd:choice>
      </xsd:complexType>
    </xsd:element>
  </xsd:schema>
  <resheader name="resmimetype">
    <value>text/microsoft-resx</value>
  </resheader>
  <resheader name="version">
    <value>2.0</value>
  </resheader>
  <resheader name="reader">
    <value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
  </resheader>
  <resheader name="writer">
    <value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
  </resheader>
</root>
```

`Program.cs`:

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串口温湿度
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

```

`Properties\AssemblyInfo.cs`:

```cs
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的一般信息由以下
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("串口温湿度")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("串口温湿度")]
[assembly: AssemblyCopyright("Copyright ©  2026")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 会使此程序集中的类型
//对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型
//请将此类型的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("103a7d98-d0c4-44dd-aae7-3974b99087ab")]

// 程序集的版本信息由下列四个值组成: 
//
//      主版本
//      次版本
//      生成号
//      修订号
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

```

`Properties\Resources.Designer.cs`:

```cs
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 4.0.30319.42000
//
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 串口温湿度.Properties
{


    /// <summary>
    ///   强类型资源类，用于查找本地化字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   返回此类使用的缓存 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((resourceMan == null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("串口温湿度.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
    }
}

```

`Properties\Resources.resx`:

```resx
<?xml version="1.0" encoding="utf-8"?>
<root>
  <!-- 
    Microsoft ResX Schema 
    
    Version 2.0
    
    The primary goals of this format is to allow a simple XML format 
    that is mostly human readable. The generation and parsing of the 
    various data types are done through the TypeConverter classes 
    associated with the data types.
    
    Example:
    
    ... ado.net/XML headers & schema ...
    <resheader name="resmimetype">text/microsoft-resx</resheader>
    <resheader name="version">2.0</resheader>
    <resheader name="reader">System.Resources.ResXResourceReader, System.Windows.Forms, ...</resheader>
    <resheader name="writer">System.Resources.ResXResourceWriter, System.Windows.Forms, ...</resheader>
    <data name="Name1"><value>this is my long string</value><comment>this is a comment</comment></data>
    <data name="Color1" type="System.Drawing.Color, System.Drawing">Blue</data>
    <data name="Bitmap1" mimetype="application/x-microsoft.net.object.binary.base64">
        <value>[base64 mime encoded serialized .NET Framework object]</value>
    </data>
    <data name="Icon1" type="System.Drawing.Icon, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
        <value>[base64 mime encoded string representing a byte array form of the .NET Framework object]</value>
        <comment>This is a comment</comment>
    </data>
                
    There are any number of "resheader" rows that contain simple 
    name/value pairs.
    
    Each data row contains a name, and value. The row also contains a 
    type or mimetype. Type corresponds to a .NET class that support 
    text/value conversion through the TypeConverter architecture. 
    Classes that don't support this are serialized and stored with the 
    mimetype set.
    
    The mimetype is used for serialized objects, and tells the 
    ResXResourceReader how to depersist the object. This is currently not 
    extensible. For a given mimetype the value must be set accordingly:
    
    Note - application/x-microsoft.net.object.binary.base64 is the format 
    that the ResXResourceWriter will generate, however the reader can 
    read any of the formats listed below.
    
    mimetype: application/x-microsoft.net.object.binary.base64
    value   : The object must be serialized with 
            : System.Serialization.Formatters.Binary.BinaryFormatter
            : and then encoded with base64 encoding.
    
    mimetype: application/x-microsoft.net.object.soap.base64
    value   : The object must be serialized with 
            : System.Runtime.Serialization.Formatters.Soap.SoapFormatter
            : and then encoded with base64 encoding.

    mimetype: application/x-microsoft.net.object.bytearray.base64
    value   : The object must be serialized into a byte array 
            : using a System.ComponentModel.TypeConverter
            : and then encoded with base64 encoding.
    -->
  <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
    <xsd:element name="root" msdata:IsDataSet="true">
      <xsd:complexType>
        <xsd:choice maxOccurs="unbounded">
          <xsd:element name="metadata">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" />
              <xsd:attribute name="type" type="xsd:string" />
              <xsd:attribute name="mimetype" type="xsd:string" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="assembly">
            <xsd:complexType>
              <xsd:attribute name="alias" type="xsd:string" />
              <xsd:attribute name="name" type="xsd:string" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="data">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
                <xsd:element name="comment" type="xsd:string" minOccurs="0" msdata:Ordinal="2" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" msdata:Ordinal="1" />
              <xsd:attribute name="type" type="xsd:string" msdata:Ordinal="3" />
              <xsd:attribute name="mimetype" type="xsd:string" msdata:Ordinal="4" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name="resheader">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" use="required" />
            </xsd:complexType>
          </xsd:element>
        </xsd:choice>
      </xsd:complexType>
    </xsd:element>
  </xsd:schema>
  <resheader name="resmimetype">
    <value>text/microsoft-resx</value>
  </resheader>
  <resheader name="version">
    <value>2.0</value>
  </resheader>
  <resheader name="reader">
    <value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
  </resheader>
  <resheader name="writer">
    <value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
  </resheader>
</root>
```

`Properties\Settings.Designer.cs`:

```cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace 串口温湿度.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }
    }
}

```

`串口温湿度.csproj`:

```csproj
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{103A7D98-D0C4-44DD-AAE7-3974B99087AB}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>串口温湿度</RootNamespace>
    <AssemblyName>串口温湿度</AssemblyName>
    <TargetFrameworkVersion>v4.8</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
    <Deterministic>true</Deterministic>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Net.Http" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Form1.resx">
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <None Include="App.config" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```