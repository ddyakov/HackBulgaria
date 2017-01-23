using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeScore
{
    class Program
    {
        public static int isPalindrome(int number)
        {
            for (int i = 0, k = number.ToString().Length - 1; i < number.ToString().Length; i++, k--)
            {
                if (number.ToString()[i] == number.ToString()[k])
                {
                    number = 1;
                }
                else
                {
                    return PScore(number);
                }
            }

            return number;
        }

        public static int ReversedNumber(int number)
        {
            string Revname = "";

            for (int i = number.ToString().Length - 1; i >= 0; i--)
            {
                Revname = Revname + number.ToString()[i];
            }

            return int.Parse(Revname);
        }

        public static int PScore(int number)
        {
            int sum = number + ReversedNumber(number);

            return sum;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(isPalindrome(number));
        }
    }
}
