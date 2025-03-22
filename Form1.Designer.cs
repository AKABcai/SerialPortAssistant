namespace 串口助手
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
            this.components = new System.ComponentModel.Container();
            this.port = new System.Windows.Forms.ComboBox();
            this.Receive = new System.Windows.Forms.RichTextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTR = new System.Windows.Forms.CheckBox();
            this.RTS = new System.Windows.Forms.CheckBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.ComboBox();
            this.check = new System.Windows.Forms.ComboBox();
            this.stop = new System.Windows.Forms.ComboBox();
            this.baud = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.receivefile = new System.Windows.Forms.TextBox();
            this.rehex = new System.Windows.Forms.CheckBox();
            this.autoclear = new System.Windows.Forms.CheckBox();
            this.choose_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autotime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendfile = new System.Windows.Forms.TextBox();
            this.sehex = new System.Windows.Forms.CheckBox();
            this.autosend = new System.Windows.Forms.CheckBox();
            this.openfile_btn = new System.Windows.Forms.Button();
            this.sendfile_btn = new System.Windows.Forms.Button();
            this.sendclear_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.state = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.receivecount = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearcount = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.data1_txb = new System.Windows.Forms.TextBox();
            this.data2_txb = new System.Windows.Forms.TextBox();
            this.data3_txb = new System.Windows.Forms.TextBox();
            this.data4_txb = new System.Windows.Forms.TextBox();
            this.data_txb = new System.Windows.Forms.TextBox();
            this.startData = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(115, 40);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(153, 23);
            this.port.TabIndex = 1;
            // 
            // Receive
            // 
            this.Receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Receive.Location = new System.Drawing.Point(3, 21);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(492, 398);
            this.Receive.TabIndex = 3;
            this.Receive.Text = "";
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(144, 24);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(105, 31);
            this.send_btn.TabIndex = 4;
            this.send_btn.Text = "手动发送";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // Send
            // 
            this.Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Send.Location = new System.Drawing.Point(3, 21);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(489, 183);
            this.Send.TabIndex = 6;
            this.Send.Text = "";
            this.Send.TextChanged += new System.EventHandler(this.Send_TextChanged);
            this.Send.Leave += new System.EventHandler(this.Send_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTR);
            this.groupBox1.Controls.Add(this.RTS);
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.baud);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // DTR
            // 
            this.DTR.AutoSize = true;
            this.DTR.Location = new System.Drawing.Point(23, 221);
            this.DTR.Name = "DTR";
            this.DTR.Size = new System.Drawing.Size(53, 19);
            this.DTR.TabIndex = 13;
            this.DTR.Text = "DTR";
            this.DTR.UseVisualStyleBackColor = true;
            // 
            // RTS
            // 
            this.RTS.AutoSize = true;
            this.RTS.Location = new System.Drawing.Point(23, 196);
            this.RTS.Name = "RTS";
            this.RTS.Size = new System.Drawing.Size(53, 19);
            this.RTS.TabIndex = 12;
            this.RTS.Text = "RTS";
            this.RTS.UseVisualStyleBackColor = true;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(126, 196);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(123, 48);
            this.open_btn.TabIndex = 11;
            this.open_btn.Text = "打开串口";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "端口号";
            // 
            // data
            // 
            this.data.FormattingEnabled = true;
            this.data.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.data.Location = new System.Drawing.Point(115, 127);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(153, 23);
            this.data.TabIndex = 5;
            // 
            // check
            // 
            this.check.FormattingEnabled = true;
            this.check.Items.AddRange(new object[] {
            "None",
            "ODD",
            "EVEN"});
            this.check.Location = new System.Drawing.Point(115, 98);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(153, 23);
            this.check.TabIndex = 4;
            // 
            // stop
            // 
            this.stop.FormattingEnabled = true;
            this.stop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stop.Location = new System.Drawing.Point(115, 156);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(153, 23);
            this.stop.TabIndex = 3;
            // 
            // baud
            // 
            this.baud.FormattingEnabled = true;
            this.baud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.baud.Location = new System.Drawing.Point(115, 69);
            this.baud.Name = "baud";
            this.baud.Size = new System.Drawing.Size(153, 23);
            this.baud.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.receivefile);
            this.groupBox2.Controls.Add(this.rehex);
            this.groupBox2.Controls.Add(this.autoclear);
            this.groupBox2.Controls.Add(this.choose_btn);
            this.groupBox2.Controls.Add(this.save_btn);
            this.groupBox2.Controls.Add(this.stop_btn);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 166);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // receivefile
            // 
            this.receivefile.Location = new System.Drawing.Point(20, 137);
            this.receivefile.Name = "receivefile";
            this.receivefile.Size = new System.Drawing.Size(230, 25);
            this.receivefile.TabIndex = 15;
            // 
            // rehex
            // 
            this.rehex.AutoSize = true;
            this.rehex.Location = new System.Drawing.Point(24, 68);
            this.rehex.Name = "rehex";
            this.rehex.Size = new System.Drawing.Size(89, 19);
            this.rehex.TabIndex = 14;
            this.rehex.Text = "十六进制";
            this.rehex.UseVisualStyleBackColor = true;
            this.rehex.CheckedChanged += new System.EventHandler(this.rehex_CheckedChanged);
            // 
            // autoclear
            // 
            this.autoclear.AutoSize = true;
            this.autoclear.Location = new System.Drawing.Point(24, 31);
            this.autoclear.Name = "autoclear";
            this.autoclear.Size = new System.Drawing.Size(89, 19);
            this.autoclear.TabIndex = 13;
            this.autoclear.Text = "自动清空";
            this.autoclear.UseVisualStyleBackColor = true;
            this.autoclear.CheckedChanged += new System.EventHandler(this.autoclear_CheckedChanged);
            // 
            // choose_btn
            // 
            this.choose_btn.Location = new System.Drawing.Point(20, 98);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(105, 31);
            this.choose_btn.TabIndex = 8;
            this.choose_btn.Text = "选择路径";
            this.choose_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(145, 98);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(105, 31);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "保存数据";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(145, 61);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(105, 31);
            this.stop_btn.TabIndex = 6;
            this.stop_btn.Text = "暂停";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(145, 24);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(105, 31);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "手动清空";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autotime);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.sendfile);
            this.groupBox3.Controls.Add(this.sehex);
            this.groupBox3.Controls.Add(this.autosend);
            this.groupBox3.Controls.Add(this.openfile_btn);
            this.groupBox3.Controls.Add(this.sendfile_btn);
            this.groupBox3.Controls.Add(this.sendclear_btn);
            this.groupBox3.Controls.Add(this.send_btn);
            this.groupBox3.Location = new System.Drawing.Point(13, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 207);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // autotime
            // 
            this.autotime.Location = new System.Drawing.Point(174, 171);
            this.autotime.Name = "autotime";
            this.autotime.Size = new System.Drawing.Size(75, 25);
            this.autotime.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "自动发送周期(ms):";
            // 
            // sendfile
            // 
            this.sendfile.Location = new System.Drawing.Point(19, 135);
            this.sendfile.Name = "sendfile";
            this.sendfile.Size = new System.Drawing.Size(230, 25);
            this.sendfile.TabIndex = 16;
            // 
            // sehex
            // 
            this.sehex.AutoSize = true;
            this.sehex.Location = new System.Drawing.Point(23, 73);
            this.sehex.Name = "sehex";
            this.sehex.Size = new System.Drawing.Size(89, 19);
            this.sehex.TabIndex = 14;
            this.sehex.Text = "十六进制";
            this.sehex.UseVisualStyleBackColor = true;
            this.sehex.CheckedChanged += new System.EventHandler(this.sehex_CheckedChanged);
            // 
            // autosend
            // 
            this.autosend.AutoSize = true;
            this.autosend.Location = new System.Drawing.Point(23, 36);
            this.autosend.Name = "autosend";
            this.autosend.Size = new System.Drawing.Size(89, 19);
            this.autosend.TabIndex = 13;
            this.autosend.Text = "自动发送";
            this.autosend.UseVisualStyleBackColor = true;
            // 
            // openfile_btn
            // 
            this.openfile_btn.Location = new System.Drawing.Point(19, 98);
            this.openfile_btn.Name = "openfile_btn";
            this.openfile_btn.Size = new System.Drawing.Size(105, 31);
            this.openfile_btn.TabIndex = 7;
            this.openfile_btn.Text = "打开文件";
            this.openfile_btn.UseVisualStyleBackColor = true;
            // 
            // sendfile_btn
            // 
            this.sendfile_btn.Location = new System.Drawing.Point(144, 98);
            this.sendfile_btn.Name = "sendfile_btn";
            this.sendfile_btn.Size = new System.Drawing.Size(105, 31);
            this.sendfile_btn.TabIndex = 6;
            this.sendfile_btn.Text = "发送文件";
            this.sendfile_btn.UseVisualStyleBackColor = true;
            // 
            // sendclear_btn
            // 
            this.sendclear_btn.Location = new System.Drawing.Point(144, 61);
            this.sendclear_btn.Name = "sendclear_btn";
            this.sendclear_btn.Size = new System.Drawing.Size(105, 31);
            this.sendclear_btn.TabIndex = 5;
            this.sendclear_btn.Text = "清空发送";
            this.sendclear_btn.UseVisualStyleBackColor = true;
            this.sendclear_btn.Click += new System.EventHandler(this.sendclear_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Receive);
            this.groupBox4.Location = new System.Drawing.Point(293, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 422);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Send);
            this.groupBox5.Location = new System.Drawing.Point(296, 440);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(495, 207);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.state,
            this.toolStripStatusLabel3,
            this.sendcount,
            this.toolStripStatusLabel5,
            this.receivecount,
            this.clearcount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1020, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // state
            // 
            this.state.AutoSize = false;
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(200, 20);
            this.state.Text = "初始化正常！";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // sendcount
            // 
            this.sendcount.AutoSize = false;
            this.sendcount.Name = "sendcount";
            this.sendcount.Size = new System.Drawing.Size(50, 20);
            this.sendcount.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // receivecount
            // 
            this.receivecount.AutoSize = false;
            this.receivecount.Name = "receivecount";
            this.receivecount.Size = new System.Drawing.Size(50, 20);
            this.receivecount.Text = "0";
            // 
            // clearcount
            // 
            this.clearcount.Name = "clearcount";
            this.clearcount.Size = new System.Drawing.Size(69, 20);
            this.clearcount.Text = "清空计数";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.startData);
            this.groupBox6.Controls.Add(this.data_txb);
            this.groupBox6.Controls.Add(this.data4_txb);
            this.groupBox6.Controls.Add(this.data3_txb);
            this.groupBox6.Controls.Add(this.data2_txb);
            this.groupBox6.Controls.Add(this.data1_txb);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(801, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 407);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "指令解析";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "数据帧";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "数据3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "数据4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "数据2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "数据1";
            // 
            // data1_txb
            // 
            this.data1_txb.Location = new System.Drawing.Point(69, 36);
            this.data1_txb.Name = "data1_txb";
            this.data1_txb.Size = new System.Drawing.Size(119, 25);
            this.data1_txb.TabIndex = 5;
            // 
            // data2_txb
            // 
            this.data2_txb.Location = new System.Drawing.Point(69, 69);
            this.data2_txb.Name = "data2_txb";
            this.data2_txb.Size = new System.Drawing.Size(119, 25);
            this.data2_txb.TabIndex = 6;
            // 
            // data3_txb
            // 
            this.data3_txb.Location = new System.Drawing.Point(69, 100);
            this.data3_txb.Name = "data3_txb";
            this.data3_txb.Size = new System.Drawing.Size(119, 25);
            this.data3_txb.TabIndex = 7;
            // 
            // data4_txb
            // 
            this.data4_txb.Location = new System.Drawing.Point(69, 131);
            this.data4_txb.Name = "data4_txb";
            this.data4_txb.Size = new System.Drawing.Size(119, 25);
            this.data4_txb.TabIndex = 8;
            // 
            // data_txb
            // 
            this.data_txb.Location = new System.Drawing.Point(9, 189);
            this.data_txb.Multiline = true;
            this.data_txb.Name = "data_txb";
            this.data_txb.Size = new System.Drawing.Size(179, 70);
            this.data_txb.TabIndex = 9;
            // 
            // startData
            // 
            this.startData.AutoSize = true;
            this.startData.Location = new System.Drawing.Point(9, 265);
            this.startData.Name = "startData";
            this.startData.Size = new System.Drawing.Size(134, 19);
            this.startData.TabIndex = 10;
            this.startData.Text = "启动数据帧接收";
            this.startData.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(6, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 30);
            this.label12.TabIndex = 11;
            this.label12.Text = "格式：\r\n     7F+长度+数据+CRC\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(14, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "例：7f0431323334DK10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 690);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.RichTextBox Receive;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.RichTextBox Send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox data;
        private System.Windows.Forms.ComboBox check;
        private System.Windows.Forms.ComboBox stop;
        private System.Windows.Forms.ComboBox baud;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button openfile_btn;
        private System.Windows.Forms.Button sendfile_btn;
        private System.Windows.Forms.Button sendclear_btn;
        private System.Windows.Forms.CheckBox RTS;
        private System.Windows.Forms.CheckBox DTR;
        private System.Windows.Forms.CheckBox rehex;
        private System.Windows.Forms.CheckBox autoclear;
        private System.Windows.Forms.CheckBox sehex;
        private System.Windows.Forms.CheckBox autosend;
        private System.Windows.Forms.TextBox receivefile;
        private System.Windows.Forms.TextBox sendfile;
        private System.Windows.Forms.TextBox autotime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel state;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sendcount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel receivecount;
        private System.Windows.Forms.ToolStripStatusLabel clearcount;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox data4_txb;
        private System.Windows.Forms.TextBox data3_txb;
        private System.Windows.Forms.TextBox data2_txb;
        private System.Windows.Forms.TextBox data1_txb;
        private System.Windows.Forms.TextBox data_txb;
        private System.Windows.Forms.CheckBox startData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

