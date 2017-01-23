using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStaticClassArrayExtension
{
    class Configuration
    {
        private static readonly char ReplacingValue = GetReplacingValue();

        public static char Replace
        {
            get
            {
                return ReplacingValue;
            }
        }

        public static int digitsSum(int number)
        {
            List<int> digits = new List<int>();
            int sum = 0;

            while (number > 0)
            {
                digits.Add(number % 10);
                number = number / 10;
            }

            for (int i = 0; i < digits.Count; i++)
            {
                sum += digits[i];
            }

            return sum;
        }

        private static char GetReplacingValue()
        {
            DateTime currTime = DateTime.Now;
            int sum = digitsSum(currTime.Day) + digitsSum(currTime.Month) + digitsSum(currTime.Year) + digitsSum(currTime.Hour) + digitsSum(currTime.Minute) + digitsSum(currTime.Second);
            sum %= 25;
            sum += 65;

            return (char)sum;
        }
    }
}
