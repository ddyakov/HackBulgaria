using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerPalindomes
{
    class Program
    {
        public static bool isIntPalindrome(int number)
        {
            for (int i = 0, k = number.ToString().Length - 1; i < number.ToString().Length; i++, k--)
            {
                if (number.ToString()[i] != number.ToString()[k])
                {
                    return false;
                }
            }

            return true;
        }

        public static int GetLargestPalindrome(int number)
        {
            for (int i = number; i > 0; i--)
            {
                if (isIntPalindrome(i))
                {
                    return i;
                }
            }

            return number;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number {0} is palindrome : {1}",number,isIntPalindrome(number));
            Console.WriteLine("The largest palindrome number smaller than {0} is : {1}", number,GetLargestPalindrome(number));
        }
    }
}
