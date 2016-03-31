using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace serial_test2
{
    public class Payesh_funcs
    {
        
        public const int R_ID=0;
        public const int R_Level=1;

        public static int[] Decode_data(string input)
        {
            int[] output = new int[0];
            int last_count = input.Count() - 1;

            for (int i = input.Count() - 1; i > -1; i--)
            {

                if (input.ElementAt(i).ToString().Equals(","))
                {
                    string number = input.Substring(i + 1, last_count - i);
                    output = Add_num(output, Int16.Parse(number));
                    last_count = i - 1;
                }
            }
            output = Add_num(output, Int16.Parse(input.Substring(0, last_count + 1)));
            return output;
        }

        public static int[] Add_num(int[] input, int new_num)
        {
            int[] output = new int[input.Count() + 1];
            output[0] = new_num;
            for (int i = 0; i < input.Count(); i++)
            {
                output[i + 1] = input[i];
            }
            return output;
        }

        public static string show_array_int(int[] input)
        {
            string output = "";
            for (int i = 0; i < input.Count(); i++)
                output += " , " + input[i];
            return output;
        }

        public static int[] Get_number_level(char ch_in)  //0 ~> number  1 ~> level
        {
            int input = (int)ch_in;
            int[] output=new int[2];
            if (input > 95) input -= 6;
            input -= 65;
            output[R_Level] = input % 4 + 1;
            output[R_ID] = input / 4;
            return output;
        }
        public static int[] Get_number_level(string st_in)  //0 ~> number  1 ~> level
        {
            char ch_in = st_in.ElementAt(0);
            int input = (int)ch_in;
            int[] output = new int[2];
            if (input > 95) input -= 6;
            input -= 65;
            output[R_Level] = input % 4 ;
            output[R_ID] = input / 4 + 1;
            return output;
        }

        public static void find_fault(Robot_spec_s input)
        {
            input.fault = false;
            for (int i = 0; i < 16; i++) input.spec_fault[i] = Robot_spec_s.white_pos;

            if (input.R_Condition[Robot_spec_s.cycle_time_us] < 2800)
            {
                input.spec_fault[Robot_spec_s.cycle_time_us] = Robot_spec_s.red_pos;
                input.fault = true;
            }
            if (input.R_Condition[Robot_spec_s.nsp] <= input.R_Condition[Robot_spec_s.nrp])
            {
                input.spec_fault[Robot_spec_s.nrp] = Robot_spec_s.red_pos;
                input.fault = true;
            }
            if (input.R_Condition[Robot_spec_s.nsp] < 30)
            {
                input.spec_fault[Robot_spec_s.nsp] = Robot_spec_s.yellow_pos; 
                input.fault = true;
                if (input.R_Condition[Robot_spec_s.nsp] < 20)
                {
                    input.spec_fault[Robot_spec_s.nsp] = Robot_spec_s.red_pos; 
                }
            }
            if (input.R_Condition[Robot_spec_s.nrp] < 20)
            {
                input.spec_fault[Robot_spec_s.nrp] = Robot_spec_s.yellow_pos;
                input.fault = true;
                if (input.R_Condition[Robot_spec_s.nrp] < 10)
                {
                    input.spec_fault[Robot_spec_s.nrp] = Robot_spec_s.red_pos; 
                }
            }

            if (input.R_Condition[Robot_spec_s.FW_low_battery] == 1)
            {
                input.spec_fault[Robot_spec_s.FW_low_battery] = Robot_spec_s.red_pos;
                input.fault = true;
            }
            if (input.R_Condition[Robot_spec_s.FW_motor_fault] == 1)
            {
                input.spec_fault[Robot_spec_s.FW_motor_fault] = Robot_spec_s.red_pos;
                input.fault = true;
            }

            if (input.R_Condition[Robot_spec_s.FW_wireless_timeout] == 1)
            {
                input.spec_fault[Robot_spec_s.FW_wireless_timeout] = Robot_spec_s.red_pos;
                input.fault = true;
            }
            //if (input.R_Condition[Robot_spec_s.wrc] > 10) 
            //{
            //    input.spec_fault[Robot_spec_s.wrc] = Robot_spec_s.yellow_pos;
            //    input.fault = true;
            //    if (input.R_Condition[Robot_spec_s.wrc] > 30)
            //    {
            //        input.spec_fault[Robot_spec_s.wrc] = Robot_spec_s.red_pos;
            //    }
            //}
            if (input.R_Condition[Robot_spec_s.bat_1000] < 11000)
            {
                input.spec_fault[Robot_spec_s.bat_1000] = Robot_spec_s.yellow_pos;
                input.fault = true;
                if (input.R_Condition[Robot_spec_s.bat_1000] < 10500)
                {
                    input.spec_fault[Robot_spec_s.bat_1000] = Robot_spec_s.red_pos;
                }
            }
        }
 
        public static string Get_data (string input,Robot_spec_s[] robots)
        {
            try
            {
                if (input.IndexOf('z') == -1)
                {
                }
                else
                {
                    string depack = input.Substring(0, input.IndexOf('z'));
                    int level = Get_number_level(depack.ElementAt(0))[R_Level];
                    int ID = Get_number_level(depack.ElementAt(0))[R_ID];

                    robots[ID].delay_ID = 0;

                    int[] data = Payesh_funcs.Decode_data(depack.Substring(1));
                    for (int i = 0; i < 4; i++) robots[ID].R_Condition[(level - 1) * 4 + i] = data[i];
                    find_fault(robots[ID]);
                    

                    // find filter
                    if (level == Robot_spec_s.filter_level) robots[ID].add_filter(robots[ID].R_Condition[Robot_spec_s.filter_num]);


                    if (input.Count() != (input.IndexOf('z') + 1)) Get_data(input.Substring(input.IndexOf('z') + 1), robots);

                    return input.Substring(input.LastIndexOf('z') + 1);
                }

            }
            catch
            {
               
            }
            return "";

        }

    }
}
