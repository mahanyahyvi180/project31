﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Time1
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }


        public void Settime(int hour, int minute, int second)
        {
            if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59) || (second < 0 || second > 59))
            {
                throw new ArgumentOutOfRangeException();
            }


            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public string ToUniversalString() => $"{Hour:D2}:{Minute:D2}:{Second:D2}";

        public override string ToString() => $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" + $"{Minute:D2}:{Second:D2}{(Hour < 12 ? "AM" : "PM")}";
         }
}


    

