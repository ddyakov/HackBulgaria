using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class Program
    {
        public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            return list;
        }

        public static IList<T> BubbleSort<T>(this IList<T> list)
            where T : IComparable
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                    {
                        Swap(list, i, i + 1);
                        sorted = false;
                    }
                }
            }

            return list;
        }

        public static void Main()
        {
            List<int> list = new List<int>() { 3, 47, 1, 80, 10 };
            var bubbleSortedList = BubbleSort(list);

            Console.WriteLine(string.Join(", ", bubbleSortedList));
        }
    }
}
