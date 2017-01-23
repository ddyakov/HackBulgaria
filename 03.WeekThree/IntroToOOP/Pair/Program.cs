using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    class Program
    {
        static void Main()
        {
            Pair obj1 = new Pair("1", 1);
            Pair obj2 = new Pair("1", 1);
            Pair obj3 = new Pair("neshto", 15);
            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj2.Equals(obj1));
            Console.WriteLine(obj3.GetHashCode());
        }
    }
}
