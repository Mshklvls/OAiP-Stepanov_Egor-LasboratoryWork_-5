using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5true
{
    internal class Time
    {
        public int hour;
        public int minute;
        public void minutes()
        {
            minute = minute + hour * 60;
        }
    }
}
