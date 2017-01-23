using System;
using System.Collections.Generic;

namespace LucasSeries
{
    class Program
    {
        public static int nthLucas(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                return nthLucas(n - 1) + nthLucas(n - 2);
            }

        }

        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The nth number is: {0}", nthLucas(number));

            int a = 2;
            int b = 1;
            int c = 0;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
