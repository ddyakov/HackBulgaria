using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAllNumbersInAGivenString
{
    class Program
    {
        public static int NumbersToAdd(string input)
        {
            int temp = 0;
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    int digit = input[i] - '0';
                    temp = temp * 10 + digit;
                }
                else
                {
                    sum += temp;
                    temp = 0;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Console.WriteLine(NumbersToAdd(input));
        }
    }
}
