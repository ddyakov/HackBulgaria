using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortWithAPredicate
{
    public delegate bool BiggerNumber<T>(T a, T b);

    class Program
    {
        public static List<T> Swap<T>(List<T> list, int a, int b)
        {
            T currNumber = list[a];
            list[a] = list[b];
            list[b] = currNumber;

            return list;
        }

        public static List<T> BubbleSortWithPredicate<T>(List<T> list, BiggerNumber<T> del)
            where T : IComparable
        {
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (del(list[i], list[i + 1]))
                    {
                        Swap(list, i, i + 1);
                        sorted = false;
                    }
                }
            }

            return list;
        }

        public static bool ReturnBigger<T>(T a, T b)
            where T : IComparable
        {
            return a.CompareTo(b) > 0;
        }

        public static void Main()
        {
            List<int> list = new List<int>() { 4, 6, 1, 2, 5, 3 };
            var bubbleSortedList = BubbleSortWithPredicate(list, ReturnBigger);

            Console.WriteLine(string.Join(", ", bubbleSortedList));
        }
    }
}
