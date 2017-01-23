using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters_selectors_
{
    public delegate bool FilterDelegate<T>(T number); 

    class Program
    {
        public static List<T> FilterCollection<T>(List<T> original, FilterDelegate<T> filter)
        {
            List<T> filtered = new List<T>();

            foreach (T item in original)
            {
                if (filter(item))
                {
                    filtered.Add(item);
                }
            }

            return filtered;
        }

        public static bool PositiveNumberFilter(int number)
        {
            return number > 0;
        }

        public static void Main()
        {
            List<int> numbers = new List<int>() { 3, 2, -5, 0, -10, 11 };
            var filtered = FilterCollection(numbers, PositiveNumberFilter);

            Console.WriteLine(string.Join(", ", filtered));
        }
    }
}
