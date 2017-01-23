using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSpan
{
    class Program
    {
        public static int MaxSpan(List<int> numbers)
        {
            int maxSpan = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currSpan = 0;
                int lastIndex = numbers.LastIndexOf(numbers[i]);

                if (lastIndex != -1)
                {
                    currSpan = (lastIndex - i) + 1;

                    if (currSpan > maxSpan)
                    {
                        maxSpan = currSpan;
                    }
                }
            }

            return maxSpan;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 4, 2, 1, 4, 1, 4 };

            Console.WriteLine(MaxSpan(numbers));
        }
    }
}
