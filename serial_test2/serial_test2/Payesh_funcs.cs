using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
 
        public static void Get_data (string input,Robot_spec_s[] robots)
        {
            int level = Get_number_level(input.ElementAt(0))[R_Level];
            int ID = Get_number_level(input.ElementAt(0))[R_ID];

            int[] data = Payesh_funcs.Decode_data(input.Substring(1));
            for (int i = 0; i < 4; i++)robots[ID].R_Condition[(level - 1) * 4 + i] = data[i];

        }

    }
}
