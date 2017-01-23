using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSums
{
    class Program
    {
        public static int sumDigits(int number)
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

        public static void PrintDatesWithGivenSum(int year, int sum)
        {
            DateTime currDate = new DateTime(year, 1, 1);
            while (currDate.Year == year)
            {
                int currDateDay = currDate.Day;
                int currDateMonth = currDate.Month;
                int sumOfAll = sumDigits(currDateDay) + sumDigits(currDateMonth) + sumDigits(year);

                if (sumOfAll == sum)
                {
                    Console.WriteLine(currDate.ToString("dd MM yyyy"));
                }
                currDate = currDate.AddDays(1);
            }
        }

        static void Main()
        {
            PrintDatesWithGivenSum(2000, 15);
        }
    }
}
