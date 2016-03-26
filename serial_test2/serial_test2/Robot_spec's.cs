using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serial_test2
{
    public class Robot_spec_s
    {
        public const int cycle_time_us=0;
        public const int FW_wireless_timeout = 1;  // FW = free wheel
        public const int FW_motor_fault = 2;
        public const int FW_low_battery = 3;
        public const int ct = 4;
        public const int nsp = 5;   // number of sent packets
        public const int nrp = 6;   // number of received packets
        public const int ss = 7;    // signal strngth
        public const int I3_full = 8;
        public const int wrc = 9;
        public const int MCU_temperature = 10;
        public const int I0 = 11;
        public const int I1 = 12;
        public const int I2 = 13;
        public const int I3 = 14;
        public const int bat_1000 = 15; // bat*1000

        public int[] R_Condition=new int[16];


    }
}
