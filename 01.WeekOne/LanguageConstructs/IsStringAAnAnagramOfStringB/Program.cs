using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringAAnAnagramOfStringB
{
    class Program
    {
        public static bool Anagram(string A, string B)
        {
            char[] input = A.ToCharArray();
            char[] input2 = B.ToCharArray();
            bool isAnagram = true;

            Array.Sort(input);
            Array.Sort(input2);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input2[i])
                {
                    isAnagram = true;
                }
                else
                {
                    return false;
                }
            }

            return isAnagram;  
        }

        static void Main()
        {
            Console.Write("Enter first string: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string input2 = Console.ReadLine();

            Console.WriteLine(Anagram(input1, input2));
        }
    }
}
