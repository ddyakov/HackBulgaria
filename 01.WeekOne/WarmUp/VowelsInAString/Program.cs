using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsInAString
{
    class Program
    {
        public static int CountVowels(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == "a" || text[i].ToString() == "e" || text[i].ToString() == "i" || text[i].ToString() == "o" || text[i].ToString() == "u" || text[i].ToString() == "y")
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main()
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine("Total number of volwels is: {0}", CountVowels(input));
        }
    }
}
