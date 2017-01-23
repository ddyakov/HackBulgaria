﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningStrings
{
    class Program
    {
        public static string JoinStrings(string separator, params string[] strings)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] != strings[strings.Length - 1])
                {
                    result.Append(strings[i]);
                    result.Append(separator);
                }
                else
                {
                    result.Append(strings[i]);
                }
            }

            return result.ToString();
        }

        static void Main()
        {
            string separator = ",";
            string[] strings = { "a", "b", "c", "d" };
            Console.WriteLine(JoinStrings(separator, strings));
        }
    }
}
