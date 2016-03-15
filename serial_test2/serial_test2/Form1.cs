using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serial_test2
{
    public partial class Serial_test : Form
    {
        int baudrate;
        string stop_bit;
        int com;
        int data_bit;
        string data_received;
        string data_send;

        private void Display_Received_Data(object sender,EventArgs e)
        {
            Receive_box.Text += data_received+"\r\n";
        }

        public Serial_test()
        {
            InitializeComponent();
        }

        private void C_D_Click(object sender, EventArgs e)
        {

            if (C_D.Text == "Connect")
            {
                switch (combo_Data_bit.Text)
                {
                    case "8":
                        data_bit = 8;
                        break;

                    case "7":
                        data_bit = 7;
                        break;

                    case "6":
                        data_bit = 6;
                        break;

                    case "5":
                        data_bit = 5;
                        break;
                }

                switch (combo_Baudrate.Text)
                {
                    case "9600":
                        baudrate = 9600;
                        break;

                    case "115200":
                        baudrate = 115200;
                        break;

                    case "4800":
                        baudrate = 4800;
                        break;

                    case "14400":
                        baudrate = 14400;
                        break;

                    case "2400":
                        baudrate = 2400;
                        break;

                    case "1200":
                        baudrate = 1200;
                        break;

                    case "600":
                        baudrate = 600;
                        break;

                    /// baghie ro nazadam -> havaset bashe
                }

                switch (combo_Parity.Text)
                {
                    case "none":
                        serialPort.Parity = Parity.None;
                        break;

                    case "odd":
                        serialPort.Parity = Parity.Odd;
                        break;

                    case "even":
                        serialPort.Parity = Parity.Even;
                        break;

                    case "space":
                        serialPort.Parity = Parity.Space;
                        break;
                }

                switch (combo_Stop_bit.Text)
                {
                    case "1":
                        serialPort.StopBits = StopBits.One;
                        break;

                    case "2":
                        serialPort.StopBits = StopBits.Two;
                        break;

                    case "0":
                        serialPort.StopBits = StopBits.None;
                        break;

                    case "1.5":
                        serialPort.StopBits = StopBits.OnePointFive;
                        break;
                }

                //  switch(combo_Handshaking.Text)         //  TODO

                serialPort.PortName = combo_COM.Text;
                serialPort.BaudRate = baudrate;
                serialPort.Handshake = Handshake.None;
                serialPort.DataBits = data_bit;
                serialPort.Open();
                serialPort.DiscardInBuffer();

                Receive_box.Text = "";

                scan.Enabled = false;
                
                C_D.Text = "Disconnect";
            }
            else if (C_D.Text == "Disconnect")
            {
                serialPort.Close();
                C_D.Text = "Connect";
                scan.Enabled = true;
            }
        }

        private void scan_Click(object sender, EventArgs e)
        {
            for (int i = 15; i > 0; i--)
            {
                try
                {
                    serialPort.PortName = "COM" + i.ToString();
                    serialPort.Open();
                    data_received="COM " + i.ToString() + "is available ." + "\n";
                    //MessageBox.Show("COM" + i.ToString() + " is available");
                    //Receive_box.Text += data_received;
                    this.Invoke(new EventHandler(Display_Received_Data));
                    combo_COM.Text = "COM" + i.ToString();
                    serialPort.Close();
                }
                catch
                {
                }
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_received = serialPort.ReadExisting();
            serialPort.DiscardInBuffer();

            this.Invoke(new EventHandler(Display_Received_Data));
        }

        private void Flush_t_Click(object sender, EventArgs e)
        {
            transfer_box.Text = "";
            data_send = "";
        }

        private void transfer_box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data_send = transfer_box.Text.Last().ToString();
                serialPort.Write(data_send);
            }
            catch
            { 
            }
        }

        

        private void Flush_r_Click(object sender, EventArgs e)
        {
            data_received = "";
            Receive_box.Text = "";
        }
    }
}
