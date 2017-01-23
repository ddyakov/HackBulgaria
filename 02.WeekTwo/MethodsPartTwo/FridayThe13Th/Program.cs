using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayThe13Th
{
    class Program
    {
        public static int UnfortunateFridays(int startYear, int endYear)
        {
            int fridaysCounter = 0;

            DateTime start = new DateTime(startYear, 1, 13);
            
            while (start.Year <= endYear)
            {
                if (start.DayOfWeek == DayOfWeek.Friday)
                {
                    fridaysCounter++;
                }
                start = start.AddMonths(1);
            }

            return fridaysCounter;
         }

        static void Main()
        {
            Console.WriteLine(UnfortunateFridays(2014,2015));
        }
    }
}
