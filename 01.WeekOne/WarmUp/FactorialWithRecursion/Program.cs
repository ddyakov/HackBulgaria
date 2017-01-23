using System;

namespace FactorialWithRecursion
{
    class Program
    {
        public static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! is: {1}", n, Factorial(n));
        }
    }
}
