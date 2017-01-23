using System;

namespace FactorialWithLoop
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                Console.WriteLine("{0}! is: {1}", n, factorial);
            }
        }
    }
}

