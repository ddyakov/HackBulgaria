using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        public static void Fibonacci(int number)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.WriteLine(b);

            for (int i = 1; i < number; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }

        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Fibonacci(number);
        }
    }
}
