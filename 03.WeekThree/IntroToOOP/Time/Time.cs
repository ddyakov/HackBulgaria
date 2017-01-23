using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time
    {
        private int year;
        private int month;
        private int day;
        private int hour;
        private int minute;
        private int second;

        public Time(string time)
        {
            string[] splitTime = time.Split(':', ' ', '.');
            hour = int.Parse(splitTime[0]);
            minute = int.Parse(splitTime[1]);
            second = int.Parse(splitTime[2]);
            day = int.Parse(splitTime[3]);
            month = int.Parse(splitTime[4]);
            year = int.Parse(splitTime[5]);
        }

        public void toString()
        {
            Console.WriteLine("{0}:{1}:{2} {3}.{4}.{5}",hour,minute,second,day,month,year);
        }

        public void now()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
