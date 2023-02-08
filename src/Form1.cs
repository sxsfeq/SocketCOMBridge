using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace SocketCOMBridge
{
    public partial class Form1 : Form
    {
        private bool _isConnected = false;
        private TcpListener _tcpListener = null;
        private TcpClient _tcpClient = null;
        private SerialPort _serialPort = new SerialPort();
        private TraceSource _traceSource = new TraceSource("log");
        private byte[] _tcpReceiveBuffer = new byte[8192];

        class RichTextTraceListener : TraceListener
        {
            private RichTextBox _richTextBox;
            public RichTextTraceListener(RichTextBox richTextBox)
            {
                _richTextBox = richTextBox;
            }

            public override void Write(string message)
            {
                if (Properties.Settings.Default.cfg_log_enable == false)
                    return;

                if (_richTextBox.InvokeRequired)
                {
                    _richTextBox.Invoke(new Action(() => _richTextBox.AppendText(message)));
                }
                else
                {
                    _richTextBox.AppendText(message);
                }
            }

            public override void WriteLine(string message)
            {
                this.Write(message + "\r\n");
            }
        }

        public Form1()
        {
            InitializeComponent();

            InitSerialPort();
            InitLogout();

            _serialPort.DataReceived += _serialPort_DataReceived;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopBridge();
            Properties.Settings.Default.Save();
        }

        private void InitLogout()
        {
            var listener = new RichTextTraceListener(richTextBox1);
            //listener.TraceOutputOptions = TraceOptions.DateTime;

            _traceSource.Switch = new SourceSwitch("SourceSwitch", "Verbose");
            _traceSource.Listeners.Clear();
            _traceSource.Listeners.Add(listener);

        }

        private void InitSerialPort()
        {
            cb_com.Items.Clear();
            cb_com.Items.AddRange(SerialPort.GetPortNames());

            cb_com.DataBindings.Add(new Binding(nameof(cb_com.SelectedIndex), Properties.Settings.Default, nameof(Properties.Settings.Default.com_name_index), true, DataSourceUpdateMode.OnPropertyChanged));
            cb_baudrate.DataBindings.Add(new Binding(nameof(cb_baudrate.SelectedIndex), Properties.Settings.Default, nameof(Properties.Settings.Default.com_baudrate_index), true, DataSourceUpdateMode.OnPropertyChanged));
            cb_stopbits.DataBindings.Add(new Binding(nameof(cb_stopbits.SelectedIndex), Properties.Settings.Default, nameof(Properties.Settings.Default.com_stopbits_index), true, DataSourceUpdateMode.OnPropertyChanged));
            cb_databits.DataBindings.Add(new Binding(nameof(cb_databits.SelectedIndex), Properties.Settings.Default, nameof(Properties.Settings.Default.com_databits_index), true, DataSourceUpdateMode.OnPropertyChanged));
            cb_parity.DataBindings.Add(new Binding(nameof(cb_parity.SelectedIndex), Properties.Settings.Default, nameof(Properties.Settings.Default.com_parity_index), true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            if (_isConnected)
                StopBridge();
            else
                StartBridge();
        }

        private void StartBridge()
        {
            // 设置串口配置
            if (cb_com.SelectedItem == null)
            {
                MessageBox.Show(this, $"未选择串口或没有可用串口");
                return;
            }

            _serialPort.PortName = cb_com.SelectedItem.ToString();

            int value;

            if (int.TryParse(cb_baudrate.Text, out value) == false)
            {
                MessageBox.Show(this, $"串口波特率无效");
                return;
            }
            _serialPort.BaudRate = value;

            if (int.TryParse(cb_databits.Text, out value) == false)
            {
                MessageBox.Show(this, $"串口数据位无效");
                return;
            }
            _serialPort.DataBits = value;

            switch (cb_stopbits.SelectedIndex)
            {
                default:
                case 0: _serialPort.StopBits = StopBits.One; break;
                case 1: _serialPort.StopBits = StopBits.OnePointFive; break;
                case 2: _serialPort.StopBits = StopBits.Two; break;
            }

            switch (cb_parity.SelectedIndex)
            {
                case 0: _serialPort.Parity = Parity.Mark; break;
                case 1: _serialPort.Parity = Parity.Space; break;
                case 2: _serialPort.Parity = Parity.Even; break;
                case 3: _serialPort.Parity = Parity.Odd; break;
                default:
                case 4: _serialPort.Parity = Parity.None; break;
            }

            IPAddress ip;

            if (IPAddress.TryParse(tb_tcp_hostname.Text, out ip) == false)
            {
                MessageBox.Show(this, "IP 地址无效");
                return;
            }

            _tcpListener = new TcpListener(ip, (int)nud_tcp_port.Value);

            try
            {
                _tcpListener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"TCP 服务器启动失败: {ex.Message}");
                return;
            }

            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                _tcpListener.Stop();
                _tcpListener = null;
                MessageBox.Show(this, $"串口打开失败: {ex.Message}");
                return;
            }

            _tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPServerAccept), null);

            btn_start_stop.Text = "停止";
            gb_com.Enabled = gb_socket.Enabled = false;

            _isConnected = true;

            _traceSource.TraceEvent(TraceEventType.Information, 1, $"TCP <> COM: 启动");
        }

        private void TCPServerAccept(IAsyncResult ar)
        {
            TcpClient client;

            try
            {
                client = _tcpListener.EndAcceptTcpClient(ar);
            }
            catch (Exception)
            {
                // Server 停止
                return;
            }

            if (_tcpClient != null)
            {
                client.Close();
                _traceSource.TraceEvent(TraceEventType.Warning, 1, "一次只接收一个客户端连接");
                return;
            };

            _tcpClient = client;
            _traceSource.TraceEvent(TraceEventType.Information, 1, $"TCP: [{client.Client.RemoteEndPoint.ToString()}] 连接");

            var stream = _tcpClient.GetStream();
            stream.BeginRead(_tcpReceiveBuffer, 0, _tcpReceiveBuffer.Length, new AsyncCallback(TCPClientDoRead), stream);

            _tcpListener.BeginAcceptTcpClient(new AsyncCallback(TCPServerAccept), null);
        }

        private void TCPClientDoRead(IAsyncResult ar)
        {
            if (_tcpClient.Connected == false)
            {
                // TCP 客户端断开
                _traceSource.TraceEvent(TraceEventType.Information, 1, $"TCP: 断开客户端");
                _tcpClient.Close();
                _tcpClient = null;
                return;
            }

            NetworkStream stream = ar.AsyncState as NetworkStream;

            int validCount = stream.EndRead(ar);

            if (validCount == 0)
            {
                // TCP 客户端断开
                _traceSource.TraceEvent(TraceEventType.Information, 1, $"TCP: [{_tcpClient.Client.RemoteEndPoint.ToString()}] 断开");
                _tcpClient.Close();
                _tcpClient = null;
                return;
            }

            _serialPort.Write(_tcpReceiveBuffer, 0, validCount);
            _traceSource.TraceEvent(TraceEventType.Information, 1, $"TCP >> COM: {GetFriendlyText(_tcpReceiveBuffer, validCount)}");
            stream.BeginRead(_tcpReceiveBuffer, 0, _tcpReceiveBuffer.Length, new AsyncCallback(TCPClientDoRead), stream);
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_tcpClient == null)
                return;

            if (_tcpClient.Connected == false)
                return;

            var stream = _tcpClient.GetStream();

            if (stream.CanWrite == false)
                return;

            while (_serialPort.BytesToRead > 0)
            {
                // 读取串口缓冲区已有的全部数据
                byte[] bytes = new byte[_serialPort.BytesToRead];
                int validCount = _serialPort.Read(bytes, 0, bytes.Length);
                stream.Write(bytes, 0, validCount);

                _traceSource.TraceEvent(TraceEventType.Information, 1, $"COM >> TCP: {GetFriendlyText(bytes, validCount)}");
            }
        }

        private void StopBridge()
        {
            _tcpClient?.Close();
            _serialPort.Close();
            _tcpListener?.Stop();
            _isConnected = false;
            btn_start_stop.Text = "启动";
            gb_com.Enabled = gb_socket.Enabled = true;
            //_traceSource.TraceEvent(TraceEventType.Information, 1, "TCP <> COM: 停止");
        }

        private void btn_sg_com_refresh_Click(object sender, EventArgs e)
        {
            cb_com.Items.Clear();
            cb_com.Items.AddRange(SerialPort.GetPortNames());
        }

        private string GetFriendlyText(byte[] data, int length)
        {
            if (rb_format_hex.Checked)
            {
                return BitConverter.ToString(data, 0, length);
            }
            else if (rb_format_string.Checked)
            {
                return Encoding.ASCII.GetString(data, 0, length);
            }
            else
            {
                return string.Empty;
            }
        }

        private void btn_clear_log_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
