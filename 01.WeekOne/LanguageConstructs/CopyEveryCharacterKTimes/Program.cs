using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyEveryCharacterKTimes
{
    class Program
    {
        public static string CopyEveryChar(string input, int k)
        {
            StringBuilder myBuilder = new StringBuilder("");

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    myBuilder.Append(input[i]);
                }
            }

            return myBuilder.ToString();
        }

        static void Main()
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();

            Console.Write("How many times you want to multiply it: ");
            int mutiply = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} * {1} = {2}", text, mutiply, CopyEveryChar(text, mutiply));
        }
    }
}
