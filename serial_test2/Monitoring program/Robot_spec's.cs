﻿using System;
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
        public const int shoot_full = 8;
        public const int wrc = 9;
        public const int MCU_temperature = 10;
        public const int I0 = 11;
        public const int I1 = 12;
        public const int I2 = 13;
        public const int I3 = 14;
        public const int bat_1000 = 15; // bat*1000

        public static string[] parameters_string = { "cycle time us", "FW wireless timeout", "FW motor fault", "FW low battery", "ct",
                                                "nsp", "nrp", "ss", "shoot full", "wrc", "temprature", "I0", "I1", "I2", "I3", "Battery low" };

        public const int white_pos = 0;
        public const int yellow_pos = 1;
        public const int red_pos = 2;

        public const int cycle_time_us_label_ID= 12;
        public const int FW_wireless_timeout_label_ID = 13;  // FW = free wheel
        public const int FW_motor_fault_label_ID = 14;
        public const int FW_low_battery_label_ID = 15;
        public const int ct_label_ID = 16;
        public const int nsp_label_ID = 17;   // number of sent packets
        public const int nrp_label_ID = 18;   // number of received packets
        public const int ss_label_ID = 19;    // signal strngth
        public const int shoot_label_ID = 20;
        public const int wrc_label_ID = 21;
        public const int MCU_temperature_label_ID = 22;
        public const int I0_label_ID = 23;
        public const int I1_label_ID = 24;
        public const int I2_label_ID = 25;
        public const int I3_label_ID = 26;
        public const int bat_1000_label_ID = 27; // bat*1000

        public int[] R_Condition=new int[16];

        public int delay_ID = 0;

        public Boolean fault = true;
        public int[] spec_fault=new int[16];



        //filter
        public const int filter_num = 9;
        public const int filter_level = 3;
        private double filter = 0;
        public void add_filter(int input)
        {
            filter = (input - filter) * 0.05 + filter;
        }
        public double give_filter()
        {
            return filter;
        }
    }
}
