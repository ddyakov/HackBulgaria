using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAndDecreasingSequences
{
    class Program
    {
        public static bool IsIncreasing(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (!(sequence[i] < sequence[i + 1]))
                {
                    return false;   
                }
            }

            return true;
        }

        public static bool IsDecreasing(int[] sequence)
        {
            return !IsIncreasing(sequence);
        }

        static void Main()
        {
            int[] arr = new int[5] { 5, 4, 3, 2, 1 };

            Console.WriteLine("Increasing: {0}",IsIncreasing(arr));
            Console.WriteLine("Decreasing: {0}",IsDecreasing(arr));
        }
    }
}
