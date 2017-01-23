using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackNumbers
{
    class Program
    {
        public static string intToBinary(int number)
        {
            string binary = Convert.ToString(number, 2);

            return binary;
        }

        public static bool isPalindrome(int number)
        {
            bool isHackOrNot = true;

            for (int i = 0, k = intToBinary(number).Length - 1; i < intToBinary(number).Length - 1; i++, k--)
            {
                if (intToBinary(number)[i] == intToBinary(number)[k])
                {
                    isHackOrNot = true;
                }
                else
                {
                    return false;
                }
            }

            return isHackOrNot;
        }

        public static bool ifHaveOddNumbersOf1(int number)
        {
            int counter = 0;
            bool ifOddNumbers = true;

            for (int i = 0; i < intToBinary(number).Length; i++)
            {
                if (intToBinary(number)[i] == 1)
                {
                    counter++;

                    if (counter % 2 == 1)
                    {
                        ifOddNumbers = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return ifOddNumbers;
        }

        public static bool isHack(int number)
        {
            bool isHackNumber = true;

            if (isPalindrome(number) && ifHaveOddNumbersOf1(number))
            {
                isHackNumber = true;
            }
            else
            {
                return false;
            }

            return isHackNumber;
        }

        public static int nextHackNumber(int number)
        {
            for (int i = number + 1; i < number * number; i++)
            {
                if (isHack(i))
                {
                    return i;
                }
            }

            return 1;
        }

        static void Main()
        {
            Console.Write("Enter number to check if it is Hack Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} is {1} = {2}", number, intToBinary(number), isHack(number));
            Console.WriteLine("The next Hack Number is: {0}", nextHackNumber(number));
        }
    }
}
