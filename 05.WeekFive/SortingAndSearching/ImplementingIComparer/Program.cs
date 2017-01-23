using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingIComparer
{
    class Program
    {
        public class MyIntComparer : IComparer<int>
        {
            public int Compare(int firstNumber, int secondNumber)
            {
                return firstNumber - secondNumber;
            }
        }

        public class LastDigitComparer : IComparer<int>
        {
            public int Compare(int firstNumber, int secondNumber)
            {
                return (firstNumber % 10) - (secondNumber % 10);
            }
        }

        public class StringLengthComparer : IComparer<string>
        {
            public int Compare(string firstString, string secondString)
            {
                if (firstString == null && secondString == null)
                    return 0;

                else if (firstString == null)
                    return 0 - secondString.Length;

                else if (secondString == null)
                    return firstString.Length - 0;

                else
                    return firstString.Length - secondString.Length;
            }
        }

        public class OddEvenComparer : IComparer<int?>
        {
            public int Compare(int? firstNumber, int? secondNumber)
            {
                if (firstNumber % 2 == 0 && secondNumber % 2 == 1)
                    return -1;
                else if (firstNumber % 2 == 1 && secondNumber % 2 == 0)
                    return 1;
                else if (firstNumber % 2 == 1 && secondNumber % 2 == 1)
                    return firstNumber.Value - secondNumber.Value;
                else if (firstNumber % 2 == 0 && secondNumber == 0)
                    return secondNumber.Value - firstNumber.Value;
                else
                {
                    if (firstNumber == null && secondNumber == null)
                        return 0;
                    else if (firstNumber == null)
                        return -1;
                    else
                        return 1;
                }
            }
        }

        public class ReverseComparer<T> : IComparer<T>
        {
            public int Compare(T firstNumber, T secondNumber)
            {
                return Comparer<T>.Default.Compare(secondNumber, firstNumber);
            }
        }

        static void Main()
        {
            string str1 = "abc";
            string str2 = null;
            var stringComparer = new StringLengthComparer();

            if (stringComparer.Compare(str1, str2) > 0)
            {
                Console.WriteLine("The first string is longer than the second string.");
            }
            else if (stringComparer.Compare(str1, str2) == 0)
            {
                Console.WriteLine("The string are equal.");
            }

            else
            {
                Console.WriteLine("The first string is shorter than the second string");
            }
                
            int? first = 12;
            int? second = 7;
            OddEvenComparer comparer = new OddEvenComparer();
            Console.WriteLine(comparer.Compare(first, second));
            Console.WriteLine();
        }
    }
}
