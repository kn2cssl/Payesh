namespace serial_test2
{
    partial class Serial_test
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
            this.combo_COM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Baudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Data_bit = new System.Windows.Forms.ComboBox();
            this.combo_Parity = new System.Windows.Forms.ComboBox();
            this.combo_Stop_bit = new System.Windows.Forms.ComboBox();
            this.combo_Handshaking = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scan = new System.Windows.Forms.Button();
            this.C_D = new System.Windows.Forms.Button();
            this.Receive_box = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.transfer_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Flush_r = new System.Windows.Forms.Button();
            this.Flush_t = new System.Windows.Forms.Button();
            this.Manual_Group = new System.Windows.Forms.GroupBox();
            this.Group_data_monitor = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.time_us_label = new System.Windows.Forms.Label();
            this.FW_wireless_label = new System.Windows.Forms.Label();
            this.FW_motor_label = new System.Windows.Forms.Label();
            this.FW_battery_label = new System.Windows.Forms.Label();
            this.ct_label = new System.Windows.Forms.Label();
            this.nsp_label = new System.Windows.Forms.Label();
            this.nrp_label = new System.Windows.Forms.Label();
            this.ss_label = new System.Windows.Forms.Label();
            this.I3_full_label = new System.Windows.Forms.Label();
            this.wrc_label = new System.Windows.Forms.Label();
            this.temp_label = new System.Windows.Forms.Label();
            this.I0_label = new System.Windows.Forms.Label();
            this.I1_label = new System.Windows.Forms.Label();
            this.I2_label = new System.Windows.Forms.Label();
            this.I3_label = new System.Windows.Forms.Label();
            this.battery_1000_label = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1.SuspendLayout();
            this.Manual_Group.SuspendLayout();
            this.Group_data_monitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_COM
            // 
            this.combo_COM.FormattingEnabled = true;
            this.combo_COM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM15"});
            this.combo_COM.Location = new System.Drawing.Point(23, 36);
            this.combo_COM.Name = "combo_COM";
            this.combo_COM.Size = new System.Drawing.Size(77, 24);
            this.combo_COM.TabIndex = 0;
            this.combo_COM.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baudrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data bit";
            // 
            // combo_Baudrate
            // 
            this.combo_Baudrate.FormattingEnabled = true;
            this.combo_Baudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.combo_Baudrate.Location = new System.Drawing.Point(142, 43);
            this.combo_Baudrate.Name = "combo_Baudrate";
            this.combo_Baudrate.Size = new System.Drawing.Size(76, 24);
            this.combo_Baudrate.TabIndex = 3;
            this.combo_Baudrate.Text = "115200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stop bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hand shake";
            // 
            // combo_Data_bit
            // 
            this.combo_Data_bit.FormattingEnabled = true;
            this.combo_Data_bit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.combo_Data_bit.Location = new System.Drawing.Point(285, 43);
            this.combo_Data_bit.Name = "combo_Data_bit";
            this.combo_Data_bit.Size = new System.Drawing.Size(39, 24);
            this.combo_Data_bit.TabIndex = 7;
            this.combo_Data_bit.Text = "8";
            // 
            // combo_Parity
            // 
            this.combo_Parity.FormattingEnabled = true;
            this.combo_Parity.Items.AddRange(new object[] {
            "none",
            "odd",
            "even",
            "mark",
            "space"});
            this.combo_Parity.Location = new System.Drawing.Point(391, 43);
            this.combo_Parity.Name = "combo_Parity";
            this.combo_Parity.Size = new System.Drawing.Size(60, 24);
            this.combo_Parity.TabIndex = 8;
            this.combo_Parity.Text = "none";
            // 
            // combo_Stop_bit
            // 
            this.combo_Stop_bit.FormattingEnabled = true;
            this.combo_Stop_bit.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.combo_Stop_bit.Location = new System.Drawing.Point(513, 43);
            this.combo_Stop_bit.Name = "combo_Stop_bit";
            this.combo_Stop_bit.Size = new System.Drawing.Size(41, 24);
            this.combo_Stop_bit.TabIndex = 9;
            this.combo_Stop_bit.Text = "1";
            // 
            // combo_Handshaking
            // 
            this.combo_Handshaking.FormattingEnabled = true;
            this.combo_Handshaking.Items.AddRange(new object[] {
            "none",
            "RTS/CTS",
            "XON/XOFF",
            "RTS/CTS+XON/XOFF",
            "RTS on TX"});
            this.combo_Handshaking.Location = new System.Drawing.Point(610, 43);
            this.combo_Handshaking.Name = "combo_Handshaking";
            this.combo_Handshaking.Size = new System.Drawing.Size(76, 24);
            this.combo_Handshaking.TabIndex = 10;
            this.combo_Handshaking.Text = "none";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scan);
            this.groupBox1.Controls.Add(this.C_D);
            this.groupBox1.Controls.Add(this.combo_COM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_Handshaking);
            this.groupBox1.Controls.Add(this.combo_Baudrate);
            this.groupBox1.Controls.Add(this.combo_Stop_bit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_Parity);
            this.groupBox1.Controls.Add(this.combo_Data_bit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting of port";
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(832, 33);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(59, 29);
            this.scan.TabIndex = 14;
            this.scan.Text = "Scan";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // C_D
            // 
            this.C_D.Location = new System.Drawing.Point(719, 27);
            this.C_D.Name = "C_D";
            this.C_D.Size = new System.Drawing.Size(102, 40);
            this.C_D.TabIndex = 11;
            this.C_D.Text = "Connect";
            this.C_D.UseVisualStyleBackColor = true;
            this.C_D.Click += new System.EventHandler(this.C_D_Click);
            // 
            // Receive_box
            // 
            this.Receive_box.Location = new System.Drawing.Point(6, 48);
            this.Receive_box.MaxLength = 100000;
            this.Receive_box.Multiline = true;
            this.Receive_box.Name = "Receive_box";
            this.Receive_box.ReadOnly = true;
            this.Receive_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Receive_box.Size = new System.Drawing.Size(452, 148);
            this.Receive_box.TabIndex = 12;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Receive data";
            // 
            // transfer_box
            // 
            this.transfer_box.Location = new System.Drawing.Point(513, 50);
            this.transfer_box.Multiline = true;
            this.transfer_box.Name = "transfer_box";
            this.transfer_box.Size = new System.Drawing.Size(378, 148);
            this.transfer_box.TabIndex = 14;
            this.transfer_box.TextChanged += new System.EventHandler(this.transfer_box_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Transfer data";
            // 
            // Flush_r
            // 
            this.Flush_r.Location = new System.Drawing.Point(6, 204);
            this.Flush_r.Name = "Flush_r";
            this.Flush_r.Size = new System.Drawing.Size(52, 29);
            this.Flush_r.TabIndex = 16;
            this.Flush_r.Text = "Flush";
            this.Flush_r.UseVisualStyleBackColor = true;
            this.Flush_r.Click += new System.EventHandler(this.Flush_r_Click);
            // 
            // Flush_t
            // 
            this.Flush_t.Location = new System.Drawing.Point(513, 204);
            this.Flush_t.Name = "Flush_t";
            this.Flush_t.Size = new System.Drawing.Size(62, 29);
            this.Flush_t.TabIndex = 17;
            this.Flush_t.Text = "Flush";
            this.Flush_t.UseVisualStyleBackColor = true;
            this.Flush_t.Click += new System.EventHandler(this.Flush_t_Click);
            // 
            // Manual_Group
            // 
            this.Manual_Group.Controls.Add(this.Receive_box);
            this.Manual_Group.Controls.Add(this.label7);
            this.Manual_Group.Controls.Add(this.transfer_box);
            this.Manual_Group.Controls.Add(this.Flush_t);
            this.Manual_Group.Controls.Add(this.Flush_r);
            this.Manual_Group.Controls.Add(this.label6);
            this.Manual_Group.Location = new System.Drawing.Point(12, 105);
            this.Manual_Group.Name = "Manual_Group";
            this.Manual_Group.Size = new System.Drawing.Size(910, 250);
            this.Manual_Group.TabIndex = 18;
            this.Manual_Group.TabStop = false;
            this.Manual_Group.Text = "Manual terminal";
            // 
            // Group_data_monitor
            // 
            this.Group_data_monitor.Controls.Add(this.battery_1000_label);
            this.Group_data_monitor.Controls.Add(this.I3_label);
            this.Group_data_monitor.Controls.Add(this.I2_label);
            this.Group_data_monitor.Controls.Add(this.I1_label);
            this.Group_data_monitor.Controls.Add(this.I0_label);
            this.Group_data_monitor.Controls.Add(this.temp_label);
            this.Group_data_monitor.Controls.Add(this.wrc_label);
            this.Group_data_monitor.Controls.Add(this.I3_full_label);
            this.Group_data_monitor.Controls.Add(this.ss_label);
            this.Group_data_monitor.Controls.Add(this.nrp_label);
            this.Group_data_monitor.Controls.Add(this.nsp_label);
            this.Group_data_monitor.Controls.Add(this.ct_label);
            this.Group_data_monitor.Controls.Add(this.FW_battery_label);
            this.Group_data_monitor.Controls.Add(this.FW_motor_label);
            this.Group_data_monitor.Controls.Add(this.FW_wireless_label);
            this.Group_data_monitor.Controls.Add(this.time_us_label);
            this.Group_data_monitor.Controls.Add(this.label23);
            this.Group_data_monitor.Controls.Add(this.label22);
            this.Group_data_monitor.Controls.Add(this.label21);
            this.Group_data_monitor.Controls.Add(this.label16);
            this.Group_data_monitor.Controls.Add(this.label20);
            this.Group_data_monitor.Controls.Add(this.label19);
            this.Group_data_monitor.Controls.Add(this.label18);
            this.Group_data_monitor.Controls.Add(this.label17);
            this.Group_data_monitor.Controls.Add(this.label15);
            this.Group_data_monitor.Controls.Add(this.label14);
            this.Group_data_monitor.Controls.Add(this.label13);
            this.Group_data_monitor.Controls.Add(this.label12);
            this.Group_data_monitor.Controls.Add(this.label11);
            this.Group_data_monitor.Controls.Add(this.label10);
            this.Group_data_monitor.Controls.Add(this.label9);
            this.Group_data_monitor.Controls.Add(this.label8);
            this.Group_data_monitor.Controls.Add(this.shapeContainer1);
            this.Group_data_monitor.Location = new System.Drawing.Point(12, 356);
            this.Group_data_monitor.Name = "Group_data_monitor";
            this.Group_data_monitor.Size = new System.Drawing.Size(910, 313);
            this.Group_data_monitor.TabIndex = 19;
            this.Group_data_monitor.TabStop = false;
            this.Group_data_monitor.Text = "Data of wireless board";
            this.Group_data_monitor.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "time_us";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "FW_wireless";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "FW_motor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "FW_battery";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(524, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "ct";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(622, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "nsp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(727, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "nrp";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(846, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "ss";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "I3_full";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(165, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 17);
            this.label17.TabIndex = 9;
            this.label17.Text = "wrc";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(284, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "temp";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(410, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "I0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(524, 219);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 17);
            this.label20.TabIndex = 12;
            this.label20.Text = "I1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(622, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "I2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(727, 219);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 17);
            this.label22.TabIndex = 14;
            this.label22.Text = "I3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(826, 219);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 17);
            this.label23.TabIndex = 15;
            this.label23.Text = "bat*1000";
            // 
            // time_us_label
            // 
            this.time_us_label.AutoSize = true;
            this.time_us_label.Location = new System.Drawing.Point(20, 174);
            this.time_us_label.Name = "time_us_label";
            this.time_us_label.Size = new System.Drawing.Size(16, 17);
            this.time_us_label.TabIndex = 16;
            this.time_us_label.Text = "0";
            // 
            // FW_wireless_label
            // 
            this.FW_wireless_label.AutoSize = true;
            this.FW_wireless_label.Location = new System.Drawing.Point(165, 174);
            this.FW_wireless_label.Name = "FW_wireless_label";
            this.FW_wireless_label.Size = new System.Drawing.Size(16, 17);
            this.FW_wireless_label.TabIndex = 17;
            this.FW_wireless_label.Text = "0";
            // 
            // FW_motor_label
            // 
            this.FW_motor_label.AutoSize = true;
            this.FW_motor_label.Location = new System.Drawing.Point(297, 174);
            this.FW_motor_label.Name = "FW_motor_label";
            this.FW_motor_label.Size = new System.Drawing.Size(16, 17);
            this.FW_motor_label.TabIndex = 18;
            this.FW_motor_label.Text = "0";
            // 
            // FW_battery_label
            // 
            this.FW_battery_label.AutoSize = true;
            this.FW_battery_label.Location = new System.Drawing.Point(413, 174);
            this.FW_battery_label.Name = "FW_battery_label";
            this.FW_battery_label.Size = new System.Drawing.Size(16, 17);
            this.FW_battery_label.TabIndex = 19;
            this.FW_battery_label.Text = "0";
            // 
            // ct_label
            // 
            this.ct_label.AutoSize = true;
            this.ct_label.Location = new System.Drawing.Point(524, 174);
            this.ct_label.Name = "ct_label";
            this.ct_label.Size = new System.Drawing.Size(16, 17);
            this.ct_label.TabIndex = 20;
            this.ct_label.Text = "0";
            // 
            // nsp_label
            // 
            this.nsp_label.AutoSize = true;
            this.nsp_label.Location = new System.Drawing.Point(622, 174);
            this.nsp_label.Name = "nsp_label";
            this.nsp_label.Size = new System.Drawing.Size(16, 17);
            this.nsp_label.TabIndex = 21;
            this.nsp_label.Text = "0";
            // 
            // nrp_label
            // 
            this.nrp_label.AutoSize = true;
            this.nrp_label.Location = new System.Drawing.Point(727, 174);
            this.nrp_label.Name = "nrp_label";
            this.nrp_label.Size = new System.Drawing.Size(16, 17);
            this.nrp_label.TabIndex = 22;
            this.nrp_label.Text = "0";
            // 
            // ss_label
            // 
            this.ss_label.AutoSize = true;
            this.ss_label.Location = new System.Drawing.Point(846, 174);
            this.ss_label.Name = "ss_label";
            this.ss_label.Size = new System.Drawing.Size(16, 17);
            this.ss_label.TabIndex = 23;
            this.ss_label.Text = "0";
            // 
            // I3_full_label
            // 
            this.I3_full_label.AutoSize = true;
            this.I3_full_label.Location = new System.Drawing.Point(20, 245);
            this.I3_full_label.Name = "I3_full_label";
            this.I3_full_label.Size = new System.Drawing.Size(16, 17);
            this.I3_full_label.TabIndex = 24;
            this.I3_full_label.Text = "0";
            // 
            // wrc_label
            // 
            this.wrc_label.AutoSize = true;
            this.wrc_label.Location = new System.Drawing.Point(165, 245);
            this.wrc_label.Name = "wrc_label";
            this.wrc_label.Size = new System.Drawing.Size(16, 17);
            this.wrc_label.TabIndex = 25;
            this.wrc_label.Text = "0";
            // 
            // temp_label
            // 
            this.temp_label.AutoSize = true;
            this.temp_label.Location = new System.Drawing.Point(297, 245);
            this.temp_label.Name = "temp_label";
            this.temp_label.Size = new System.Drawing.Size(16, 17);
            this.temp_label.TabIndex = 26;
            this.temp_label.Text = "0";
            // 
            // I0_label
            // 
            this.I0_label.AutoSize = true;
            this.I0_label.Location = new System.Drawing.Point(413, 245);
            this.I0_label.Name = "I0_label";
            this.I0_label.Size = new System.Drawing.Size(16, 17);
            this.I0_label.TabIndex = 27;
            this.I0_label.Text = "0";
            // 
            // I1_label
            // 
            this.I1_label.AutoSize = true;
            this.I1_label.Location = new System.Drawing.Point(524, 245);
            this.I1_label.Name = "I1_label";
            this.I1_label.Size = new System.Drawing.Size(16, 17);
            this.I1_label.TabIndex = 20;
            this.I1_label.Text = "0";
            // 
            // I2_label
            // 
            this.I2_label.AutoSize = true;
            this.I2_label.Location = new System.Drawing.Point(625, 245);
            this.I2_label.Name = "I2_label";
            this.I2_label.Size = new System.Drawing.Size(16, 17);
            this.I2_label.TabIndex = 28;
            this.I2_label.Text = "0";
            // 
            // I3_label
            // 
            this.I3_label.AutoSize = true;
            this.I3_label.Location = new System.Drawing.Point(727, 245);
            this.I3_label.Name = "I3_label";
            this.I3_label.Size = new System.Drawing.Size(16, 17);
            this.I3_label.TabIndex = 29;
            this.I3_label.Text = "0";
            // 
            // battery_1000_label
            // 
            this.battery_1000_label.AutoSize = true;
            this.battery_1000_label.Location = new System.Drawing.Point(846, 245);
            this.battery_1000_label.Name = "battery_1000_label";
            this.battery_1000_label.Size = new System.Drawing.Size(16, 17);
            this.battery_1000_label.TabIndex = 20;
            this.battery_1000_label.Text = "0";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(904, 292);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 887;
            this.lineShape1.Y1 = 124;
            this.lineShape1.Y2 = 126;
            // 
            // Serial_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 681);
            this.Controls.Add(this.Group_data_monitor);
            this.Controls.Add(this.Manual_Group);
            this.Controls.Add(this.groupBox1);
            this.Name = "Serial_test";
            this.Text = "Payesh_proj";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Manual_Group.ResumeLayout(false);
            this.Manual_Group.PerformLayout();
            this.Group_data_monitor.ResumeLayout(false);
            this.Group_data_monitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_COM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_Baudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_Data_bit;
        private System.Windows.Forms.ComboBox combo_Parity;
        private System.Windows.Forms.ComboBox combo_Stop_bit;
        private System.Windows.Forms.ComboBox combo_Handshaking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button C_D;
        private System.Windows.Forms.TextBox Receive_box;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.TextBox transfer_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Flush_r;
        private System.Windows.Forms.Button Flush_t;
        private System.Windows.Forms.GroupBox Manual_Group;
        private System.Windows.Forms.GroupBox Group_data_monitor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label battery_1000_label;
        private System.Windows.Forms.Label I3_label;
        private System.Windows.Forms.Label I2_label;
        private System.Windows.Forms.Label I1_label;
        private System.Windows.Forms.Label I0_label;
        private System.Windows.Forms.Label temp_label;
        private System.Windows.Forms.Label wrc_label;
        private System.Windows.Forms.Label I3_full_label;
        private System.Windows.Forms.Label ss_label;
        private System.Windows.Forms.Label nrp_label;
        private System.Windows.Forms.Label nsp_label;
        private System.Windows.Forms.Label ct_label;
        private System.Windows.Forms.Label FW_battery_label;
        private System.Windows.Forms.Label FW_motor_label;
        private System.Windows.Forms.Label FW_wireless_label;
        private System.Windows.Forms.Label time_us_label;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

