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
            //String s = "A54545z0z,80,2,156";
            //MessageBox.Show(s.Substring(0,s.IndexOf('z')).ToString());

            //////string[] k = new string[6];
            //////while(s.IndexOf(',',0));
            //////int[] a = Payesh_funcs.Decode_data(s.Substring(1));
            
            //////bool[] b = Reza_test.String2bool(s);

            ////Robot_spec_s[] test = new Robot_spec_s[12];
            ////for (int i = 0; i < 12; i++) test[i] = new Robot_spec_s();
            ////Payesh_funcs.Get_data(s, test);
            ////MessageBox.Show(test[0].robot_data[1].ToString()); //s.ElementAt(2).ToString()
            //////MessageBox.Show("Hilkakdjlksdjlkfjasdljlll".Last().ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Serial_test());
            
        }
    }
}
