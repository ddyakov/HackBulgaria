using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharHistogram
{
    class Program
    {
        public static Dictionary<char,int> CharHistogram(string text)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter] += 1;
                }
                else
                {
                    dictionary.Add(letter, 1);
                }
            }

            foreach (var letter in dictionary)
            {
                Console.WriteLine("{0} : {1}", letter.Key, letter.Value);
            }

            return dictionary;
        }

        static void Main()
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine();

            CharHistogram(input);
        }
    }
}
