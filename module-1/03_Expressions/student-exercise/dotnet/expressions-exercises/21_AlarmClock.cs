﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {

        /*
         Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat, and a bool indicating if we are
         on vacation, return a string of the form "7:00" indicating when the alarm clock should ring. Weekdays,
         the alarm should be "7:00" and on the weekend it should be "10:00". Unless we are on vacation -- then
         on weekdays it should be "10:00" and weekends it should be "off".
         AlarmClock(1, false) → "7:00"
         AlarmClock(5, false) → "7:00"
         AlarmClock(0, false) → "10:00"
         */
        public string AlarmClock(int day, bool vacation)
        {
            string alarmTime = "7:00";
            if (vacation == false)
            {
                if (day == 6 || day == 0)
                {
                    alarmTime = "10:00";
                }
            }
            else if(vacation==true)
            {
                alarmTime="10:00";
                if (day==6 ||day==0)
                {
                    alarmTime = "off";
                }

            }

            return alarmTime;
        }

    }
}
