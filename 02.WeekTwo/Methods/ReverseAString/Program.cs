using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        public static void ReverseList(ref List<int> list)
        {
            list.ToArray();
            list.Reverse();
        }

        static void Main()
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5 };
            ReverseList(ref input);

            foreach (var number in input)
            {
                Console.WriteLine("{0}",number);
            }
        }
    }
}
