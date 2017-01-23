using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsonantsInAString
{
    class Program
    {
        public static int CountConsonants(string text)
        {
            int counter = 0;
            char[] consonantstsArray = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < consonantstsArray.Length; j++)
                {
                    if (text[i].ToString() == consonantstsArray[j].ToString())
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        static void Main()
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine("The number of consonants is: {0}", CountConsonants(input));
        }
    }
}
