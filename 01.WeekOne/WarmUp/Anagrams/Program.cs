﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        public static bool IsAnagram(string A, string B)
        {
            Dictionary<char, int> aDictionary = new Dictionary<char, int>();
            foreach (var letter in A)
            {
                if (aDictionary.ContainsKey(letter))
                {
                    aDictionary[letter] += 1;
                }
                else
                {
                    aDictionary.Add(letter, 1);
                }
            }
            Dictionary<char, int> bDictionary = new Dictionary<char, int>();
            foreach (var letter in B)
            {
                if (bDictionary.ContainsKey(letter))
                {
                    bDictionary[letter] += 1;
                }
                else
                {
                    bDictionary.Add(letter, 1);
                }
            }
            bool IsEqual = aDictionary.OrderBy(r => r.Key).SequenceEqual(bDictionary.OrderBy(r => r.Key));
            return IsEqual;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string firstInput = Console.ReadLine();
            Console.Write("Enter second string: ");
            string secondInput = Console.ReadLine();
            Console.Write("String \"{0}\" and string \"{1}\" are anagrams : {2}  ", firstInput, secondInput, IsAnagram(firstInput, secondInput));
            Console.WriteLine();
        }
    }
}
