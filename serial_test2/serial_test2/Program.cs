using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serial_test2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //Robot_spec_s[] robots = new Robot_spec_s[12];
            //for (int i = 0; i < 12; i++) robots[i] = new Robot_spec_s();
            //Payesh_funcs.Get_data("A0,1,2,3z", robots);
            //Payesh_funcs.Get_data("B4,5,", robots);
            //Payesh_funcs.Get_data("6,7zC8,9,10,11z", robots);
            //Payesh_funcs.Get_data("D12,13,14,15z", robots);

            //Payesh_funcs.Get_data("E19,44,55,66z", robots);
            //Payesh_funcs.Get_data("D12,13,14,15zF4,", robots);
            //Payesh_funcs.Get_data("G8,9,10,185zH156", robots);
            ////Payesh_funcs.Get_data("", robots);
            //Payesh_funcs.Get_data(",89,21,33zI12,slkdkjfas13,14,15zJ4", robots);
            //Payesh_funcs.Get_data("A0,1,2,3zB0,1,2,999zJ45,65,8,875zC0,1,2,865z", robots);

            //MessageBox.Show(Payesh_funcs.Get_data("A45,56,8,9zB45,3,2,6z",robots));

            //MessageBox.Show(Int32.Parse("-5").ToString());

            ////string[] k = new string[6];
            ////while(s.IndexOf(',',0));
            ////int[] a = Payesh_funcs.Decode_data(s.Substring(1));
            
            ////bool[] b = Reza_test.String2bool(s);

            //Robot_spec_s[] test = new Robot_spec_s[12];
            //for (int i = 0; i < 12; i++) test[i] = new Robot_spec_s();
            //Payesh_funcs.Get_data(s, test);
            //MessageBox.Show(test[0].robot_data[1].ToString()); //s.ElementAt(2).ToString()
            ////MessageBox.Show("Hilkakdjlksdjlkfjasdljlll".Last().ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Serial_test());
            
        }
    }
}
