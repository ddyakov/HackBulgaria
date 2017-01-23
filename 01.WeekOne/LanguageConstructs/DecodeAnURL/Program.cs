using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAnURL
{
    class Program
    {
        public static string DecodeUrl(string input)
        {
            StringBuilder replacer = new StringBuilder("kitten%20pic.jpg");

            for (int i = 0; i < input.Length; i++)
            {
                replacer.Replace("%20", " ");
                replacer.Replace("%3A", ":");
                replacer.Replace("%3D", "?");
                replacer.Replace("%2F", "/");
            }

            return replacer.ToString();
        }

        static void Main()
        {
            string input = "kitten%20pic.jpg";

            Console.WriteLine(DecodeUrl(input));
        }
    }
}
