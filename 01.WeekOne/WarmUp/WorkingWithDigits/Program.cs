using System;
using System.Linq;
using System.Collections.Generic;

namespace WorkingWithDigits
{
    class Program
    {

        public static int countDigits(string number)
        {
            return number.Length;
        }

        public static int sumDigits(IList<int> numbers)
        {
            int sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }

            return sum;
        }

        public static int factorialDigits(IList<int> numbers)
        {
            int sum = 0;

            foreach (var item in numbers)
            {
                sum += findFactorial(item);
            }

            return sum;
        }

        public static int findFactorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static void Main()
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            List<int> numbers = new List<int>();

            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(int.Parse(number[i].ToString()));
            }

            Console.WriteLine("The count of the numbers is: {0}", countDigits(number));
            Console.WriteLine("The sum of the numbers is: {0}", sumDigits(numbers));
            Console.WriteLine("The sum of digit's factorial is: {0}", factorialDigits(numbers));

        }
    }
}
