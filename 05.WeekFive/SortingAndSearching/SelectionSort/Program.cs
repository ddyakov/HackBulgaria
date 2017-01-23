using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public static class Program
    {
        public static IList<T> SelectSort<T>(this IList<T> list)
            where T : IComparable
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[min].CompareTo(list[j]) > 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var temp = list[i];
                    list[i] = list[min];
                    list[min] = temp;
                }
            }

            return list;
        }

        public static void Main()
        {
            List<int> list = new List<int>() { 4, 11, 120, 45, 21, 234, 1 };
            var selectionSortedList = SelectSort(list);

            Console.WriteLine(string.Join(", ", selectionSortedList));
        }
    }
}
