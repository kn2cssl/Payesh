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
            this.combo_COM.Size = new System.Drawing.Size(68, 24);
            this.combo_COM.TabIndex = 0;
            this.combo_COM.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baudrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 18);
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
            this.combo_Baudrate.Location = new System.Drawing.Point(129, 43);
            this.combo_Baudrate.Name = "combo_Baudrate";
            this.combo_Baudrate.Size = new System.Drawing.Size(76, 24);
            this.combo_Baudrate.TabIndex = 3;
            this.combo_Baudrate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stop bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 18);
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
            this.combo_Data_bit.Location = new System.Drawing.Point(246, 43);
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
            this.combo_Parity.Location = new System.Drawing.Point(327, 43);
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
            this.combo_Stop_bit.Location = new System.Drawing.Point(426, 43);
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
            this.combo_Handshaking.Location = new System.Drawing.Point(503, 43);
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
            this.groupBox1.Size = new System.Drawing.Size(787, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting of port";
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(719, 33);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(59, 29);
            this.scan.TabIndex = 14;
            this.scan.Text = "Scan";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // C_D
            // 
            this.C_D.Location = new System.Drawing.Point(602, 24);
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
            this.Receive_box.Multiline = true;
            this.Receive_box.Name = "Receive_box";
            this.Receive_box.ReadOnly = true;
            this.Receive_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Receive_box.Size = new System.Drawing.Size(339, 148);
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
            this.transfer_box.Location = new System.Drawing.Point(426, 48);
            this.transfer_box.Multiline = true;
            this.transfer_box.Name = "transfer_box";
            this.transfer_box.Size = new System.Drawing.Size(339, 148);
            this.transfer_box.TabIndex = 14;
            this.transfer_box.TextChanged += new System.EventHandler(this.transfer_box_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 28);
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
            this.Flush_t.Location = new System.Drawing.Point(426, 204);
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
            this.Manual_Group.Size = new System.Drawing.Size(787, 250);
            this.Manual_Group.TabIndex = 18;
            this.Manual_Group.TabStop = false;
            this.Manual_Group.Text = "Manual terminal";
            // 
            // Group_data_monitor
            // 
            this.Group_data_monitor.Controls.Add(this.label8);
            this.Group_data_monitor.Location = new System.Drawing.Point(12, 369);
            this.Group_data_monitor.Name = "Group_data_monitor";
            this.Group_data_monitor.Size = new System.Drawing.Size(787, 278);
            this.Group_data_monitor.TabIndex = 19;
            this.Group_data_monitor.TabStop = false;
            this.Group_data_monitor.Text = "Data of wireless board";
            this.Group_data_monitor.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // Serial_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 736);
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
    }
}

