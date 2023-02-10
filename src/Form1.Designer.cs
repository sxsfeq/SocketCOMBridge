namespace SocketCOMBridge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SocketCOMBridge.Properties.Settings settings1 = new SocketCOMBridge.Properties.Settings();
            this.gb_com = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sg_com_refresh = new System.Windows.Forms.Button();
            this.cb_com = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_baudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_databits = new System.Windows.Forms.ComboBox();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.cb_stopbits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.nud_com_recv_timeout = new System.Windows.Forms.NumericUpDown();
            this.label_com_recv_timeout_unit = new System.Windows.Forms.Label();
            this.cb_com_recv_timeout = new System.Windows.Forms.ComboBox();
            this.gb_socket = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nud_tcp_port = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_conn_tcp = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tcp_hostname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_log_enable = new System.Windows.Forms.CheckBox();
            this.btn_clear_log = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_format_hex = new System.Windows.Forms.RadioButton();
            this.rb_format_string = new System.Windows.Forms.RadioButton();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gb_com.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_com_recv_timeout)).BeginInit();
            this.gb_socket.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tcp_port)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_com
            // 
            this.gb_com.Controls.Add(this.tableLayoutPanel1);
            this.gb_com.Location = new System.Drawing.Point(16, 16);
            this.gb_com.Margin = new System.Windows.Forms.Padding(5);
            this.gb_com.Name = "gb_com";
            this.gb_com.Padding = new System.Windows.Forms.Padding(5);
            this.gb_com.Size = new System.Drawing.Size(360, 294);
            this.gb_com.TabIndex = 3;
            this.gb_com.TabStop = false;
            this.gb_com.Text = "串口";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_baudrate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_databits, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb_parity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_stopbits, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 266);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sg_com_refresh);
            this.panel1.Controls.Add(this.cb_com);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(81, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 36);
            this.panel1.TabIndex = 4;
            // 
            // btn_sg_com_refresh
            // 
            this.btn_sg_com_refresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_sg_com_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_sg_com_refresh.Image")));
            this.btn_sg_com_refresh.Location = new System.Drawing.Point(217, -1);
            this.btn_sg_com_refresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_sg_com_refresh.Name = "btn_sg_com_refresh";
            this.btn_sg_com_refresh.Size = new System.Drawing.Size(44, 38);
            this.btn_sg_com_refresh.TabIndex = 75;
            this.btn_sg_com_refresh.UseVisualStyleBackColor = true;
            this.btn_sg_com_refresh.Click += new System.EventHandler(this.btn_sg_com_refresh_Click);
            // 
            // cb_com
            // 
            this.cb_com.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_com.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_com.FormattingEnabled = true;
            this.cb_com.Location = new System.Drawing.Point(1, 5);
            this.cb_com.Margin = new System.Windows.Forms.Padding(0);
            this.cb_com.Name = "cb_com";
            this.cb_com.Size = new System.Drawing.Size(211, 28);
            this.cb_com.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "波特率";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据位";
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_baudrate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.cb_baudrate.Location = new System.Drawing.Point(82, 52);
            this.cb_baudrate.Margin = new System.Windows.Forms.Padding(5);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(263, 28);
            this.cb_baudrate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "校验";
            // 
            // cb_databits
            // 
            this.cb_databits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_databits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_databits.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_databits.FormattingEnabled = true;
            this.cb_databits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cb_databits.Location = new System.Drawing.Point(82, 96);
            this.cb_databits.Margin = new System.Windows.Forms.Padding(5);
            this.cb_databits.MaxLength = 1;
            this.cb_databits.Name = "cb_databits";
            this.cb_databits.Size = new System.Drawing.Size(263, 28);
            this.cb_databits.TabIndex = 1;
            // 
            // cb_parity
            // 
            this.cb_parity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_parity.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Items.AddRange(new object[] {
            "标记(Mark)",
            "空格(Space)",
            "偶(Even)",
            "奇(Odd)",
            "无(None)"});
            this.cb_parity.Location = new System.Drawing.Point(82, 140);
            this.cb_parity.Margin = new System.Windows.Forms.Padding(5);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(263, 28);
            this.cb_parity.TabIndex = 1;
            // 
            // cb_stopbits
            // 
            this.cb_stopbits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_stopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stopbits.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_stopbits.FormattingEnabled = true;
            this.cb_stopbits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cb_stopbits.Location = new System.Drawing.Point(82, 184);
            this.cb_stopbits.Margin = new System.Windows.Forms.Padding(5);
            this.cb_stopbits.Name = "cb_stopbits";
            this.cb_stopbits.Size = new System.Drawing.Size(263, 28);
            this.cb_stopbits.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "停止位";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "波特率";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "接收分包";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.nud_com_recv_timeout, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label_com_recv_timeout_unit, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.cb_com_recv_timeout, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(80, 223);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(267, 40);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // nud_com_recv_timeout
            // 
            this.nud_com_recv_timeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_com_recv_timeout.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SocketCOMBridge.Properties.Settings.Default, "com_recv_timeout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nud_com_recv_timeout.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_com_recv_timeout.Location = new System.Drawing.Point(156, 5);
            this.nud_com_recv_timeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_com_recv_timeout.MinimumSize = new System.Drawing.Size(80, 0);
            this.nud_com_recv_timeout.Name = "nud_com_recv_timeout";
            this.nud_com_recv_timeout.Size = new System.Drawing.Size(80, 30);
            this.nud_com_recv_timeout.TabIndex = 1;
            this.nud_com_recv_timeout.Value = global::SocketCOMBridge.Properties.Settings.Default.com_recv_timeout;
            // 
            // label_com_recv_timeout_unit
            // 
            this.label_com_recv_timeout_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_com_recv_timeout_unit.AutoSize = true;
            this.label_com_recv_timeout_unit.Location = new System.Drawing.Point(239, 12);
            this.label_com_recv_timeout_unit.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label_com_recv_timeout_unit.Name = "label_com_recv_timeout_unit";
            this.label_com_recv_timeout_unit.Size = new System.Drawing.Size(23, 15);
            this.label_com_recv_timeout_unit.TabIndex = 0;
            this.label_com_recv_timeout_unit.Text = "ms";
            this.label_com_recv_timeout_unit.Visible = false;
            // 
            // cb_com_recv_timeout
            // 
            this.cb_com_recv_timeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_com_recv_timeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_com_recv_timeout.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_com_recv_timeout.FormattingEnabled = true;
            this.cb_com_recv_timeout.Items.AddRange(new object[] {
            "否(实时转发)",
            "超时时间"});
            this.cb_com_recv_timeout.Location = new System.Drawing.Point(3, 6);
            this.cb_com_recv_timeout.Name = "cb_com_recv_timeout";
            this.cb_com_recv_timeout.Size = new System.Drawing.Size(147, 28);
            this.cb_com_recv_timeout.TabIndex = 0;
            this.cb_com_recv_timeout.SelectedIndexChanged += new System.EventHandler(this.cb_com_recv_timeout_SelectedIndexChanged);
            // 
            // gb_socket
            // 
            this.gb_socket.Controls.Add(this.tableLayoutPanel2);
            this.gb_socket.Location = new System.Drawing.Point(385, 16);
            this.gb_socket.Margin = new System.Windows.Forms.Padding(4);
            this.gb_socket.Name = "gb_socket";
            this.gb_socket.Padding = new System.Windows.Forms.Padding(4);
            this.gb_socket.Size = new System.Drawing.Size(360, 294);
            this.gb_socket.TabIndex = 4;
            this.gb_socket.TabStop = false;
            this.gb_socket.Text = "Socket";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.nud_tcp_port, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_tcp_hostname, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 22);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 268);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nud_tcp_port
            // 
            this.nud_tcp_port.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nud_tcp_port.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_tcp_port.Location = new System.Drawing.Point(72, 219);
            this.nud_tcp_port.Margin = new System.Windows.Forms.Padding(5);
            this.nud_tcp_port.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nud_tcp_port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_tcp_port.Name = "nud_tcp_port";
            this.nud_tcp_port.Size = new System.Drawing.Size(93, 30);
            this.nud_tcp_port.TabIndex = 72;
            this.nud_tcp_port.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "协议";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "IP";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "端口";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rb_conn_tcp, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(71, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(277, 59);
            this.tableLayoutPanel3.TabIndex = 73;
            // 
            // rb_conn_tcp
            // 
            this.rb_conn_tcp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_conn_tcp.AutoSize = true;
            this.rb_conn_tcp.Checked = true;
            this.rb_conn_tcp.Location = new System.Drawing.Point(4, 20);
            this.rb_conn_tcp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rb_conn_tcp.Name = "rb_conn_tcp";
            this.rb_conn_tcp.Size = new System.Drawing.Size(130, 19);
            this.rb_conn_tcp.TabIndex = 73;
            this.rb_conn_tcp.TabStop = true;
            this.rb_conn_tcp.Text = "TCP";
            this.rb_conn_tcp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(71, 71);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(277, 59);
            this.tableLayoutPanel4.TabIndex = 74;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 20);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 19);
            this.radioButton1.TabIndex = 73;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "服务端";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "类型";
            // 
            // tb_tcp_hostname
            // 
            this.tb_tcp_hostname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tcp_hostname.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_tcp_hostname.Location = new System.Drawing.Point(72, 152);
            this.tb_tcp_hostname.Margin = new System.Windows.Forms.Padding(5);
            this.tb_tcp_hostname.Name = "tb_tcp_hostname";
            this.tb_tcp_hostname.Size = new System.Drawing.Size(275, 30);
            this.tb_tcp_hostname.TabIndex = 71;
            this.tb_tcp_hostname.Text = "127.0.0.1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_log_enable);
            this.groupBox3.Controls.Add(this.btn_clear_log);
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Controls.Add(this.btn_start_stop);
            this.groupBox3.Location = new System.Drawing.Point(753, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(219, 294);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // cb_log_enable
            // 
            this.cb_log_enable.AutoSize = true;
            settings1.cfg_log_enable = true;
            settings1.com_baudrate_index = 11;
            settings1.com_databits_index = 2;
            settings1.com_name_index = 0;
            settings1.com_parity_index = 4;
            settings1.com_recv_timeout = new decimal(new int[] {
            10,
            0,
            0,
            0});
            settings1.com_recv_type = 1;
            settings1.com_stopbits_index = 0;
            settings1.SettingsKey = "";
            this.cb_log_enable.Checked = settings1.cfg_log_enable;
            this.cb_log_enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_log_enable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "cfg_log_enable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_log_enable.Location = new System.Drawing.Point(12, 209);
            this.cb_log_enable.Name = "cb_log_enable";
            this.cb_log_enable.Size = new System.Drawing.Size(97, 19);
            this.cb_log_enable.TabIndex = 3;
            this.cb_log_enable.Text = "日志显示:";
            this.cb_log_enable.UseVisualStyleBackColor = true;
            // 
            // btn_clear_log
            // 
            this.btn_clear_log.Location = new System.Drawing.Point(123, 204);
            this.btn_clear_log.Name = "btn_clear_log";
            this.btn_clear_log.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_log.TabIndex = 2;
            this.btn_clear_log.Text = "清除";
            this.btn_clear_log.UseVisualStyleBackColor = true;
            this.btn_clear_log.Click += new System.EventHandler(this.btn_clear_log_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.rb_format_hex, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.rb_format_string, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 244);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(203, 35);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // rb_format_hex
            // 
            this.rb_format_hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_format_hex.AutoSize = true;
            this.rb_format_hex.Checked = true;
            this.rb_format_hex.Location = new System.Drawing.Point(4, 8);
            this.rb_format_hex.Margin = new System.Windows.Forms.Padding(4);
            this.rb_format_hex.Name = "rb_format_hex";
            this.rb_format_hex.Size = new System.Drawing.Size(93, 19);
            this.rb_format_hex.TabIndex = 0;
            this.rb_format_hex.TabStop = true;
            this.rb_format_hex.Text = "HEX";
            this.rb_format_hex.UseVisualStyleBackColor = true;
            // 
            // rb_format_string
            // 
            this.rb_format_string.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_format_string.AutoSize = true;
            this.rb_format_string.Location = new System.Drawing.Point(105, 8);
            this.rb_format_string.Margin = new System.Windows.Forms.Padding(4);
            this.rb_format_string.Name = "rb_format_string";
            this.rb_format_string.Size = new System.Drawing.Size(94, 19);
            this.rb_format_string.TabIndex = 0;
            this.rb_format_string.Text = "String";
            this.rb_format_string.UseVisualStyleBackColor = true;
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start_stop.Location = new System.Drawing.Point(37, 47);
            this.btn_start_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(145, 71);
            this.btn_start_stop.TabIndex = 0;
            this.btn_start_stop.Text = "启动";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(16, 319);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(955, 309);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 644);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_socket);
            this.Controls.Add(this.gb_com);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socket COM Bridge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gb_com.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_com_recv_timeout)).EndInit();
            this.gb_socket.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tcp_port)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_com;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.ComboBox cb_stopbits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_databits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sg_com_refresh;
        private System.Windows.Forms.ComboBox cb_com;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_socket;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown nud_tcp_port;
        private System.Windows.Forms.TextBox tb_tcp_hostname;
        private System.Windows.Forms.RadioButton rb_conn_tcp;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_start_stop;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton rb_format_hex;
        private System.Windows.Forms.RadioButton rb_format_string;
        private System.Windows.Forms.Button btn_clear_log;
        private System.Windows.Forms.CheckBox cb_log_enable;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox cb_com_recv_timeout;
        private System.Windows.Forms.NumericUpDown nud_com_recv_timeout;
        private System.Windows.Forms.Label label_com_recv_timeout_unit;
    }
}

