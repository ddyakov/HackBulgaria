using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeElementsInAList
{
    class Program
    {
        public static int Min(int[] items)
        {
            return items.Min();
        }

        public static int Max(int[] items)
        {
            return items.Max();
        }

        public static int NthMin(int number, int[] items)
        {
            var sorted = items.OrderBy(i => i).ToList();
            return sorted[number];
        }

        public static int NthMax(int number, int[]items)
        {
            var sorted = items.OrderByDescending(i => i).ToList();
            return sorted[number];
        }

        static void Main()
        {
            int[] arr = new int[5] { 5, 11, 4, 7, 10 };

            Console.WriteLine("Min: {0}", Min(arr));
            Console.WriteLine("Max: {0}", Max(arr));

            Console.Write("Which nthMin you want: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Nth Min: {0}", NthMin(number,arr));
            Console.WriteLine("Nth Max: {0}", NthMax(number,arr));
        }
    }
}
