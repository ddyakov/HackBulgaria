using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        public static string ReverseEveryWord(string text)
        {
            string Revname = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Revname = Revname + text[i];
            }

            return Revname;
        }

        static void Main()
        {
            Console.Write("Enter some text: ");
            string name = Console.ReadLine();

            Console.WriteLine("Reversed string: {0}", ReverseEveryWord(name));
        }
    }
}
