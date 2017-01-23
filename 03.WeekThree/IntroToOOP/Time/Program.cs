using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter date in the format \"hh:mm:ss dd.mm.yy\"");
            string time = Console.ReadLine();
            Time ob1 = new Time(time);
            ob1.ToString();
            ob1.now();
        }
    }
}
