using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayRanges
{
    class Program
    {
        public static List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            foreach (var range in ranges)
            {
                
            }
        }

        static void Main()
        {
            List<int> birthdays = new List<int>() { 5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15 };
            List<KeyValuePair<int, int>> ranges = new List<KeyValuePair<int, int>>();
            ranges.Add(new KeyValuePair<int, int>(4, 9));
            ranges.Add(new KeyValuePair<int, int>(6, 7));
            ranges.Add(new KeyValuePair<int, int>(200, 225));
            ranges.Add(new KeyValuePair<int, int>(300, 365));
        }
    }
}
