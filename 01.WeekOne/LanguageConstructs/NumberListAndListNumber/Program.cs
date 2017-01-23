using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberListAndListNumber
{
    class Program
    {
        public static List<int> NumberToList(int number)
        {
            List<int> DigitsList = new List<int>();

            while (number > 0)
            {
                DigitsList.Add(number % 10);
                number /= 10;
            }


            DigitsList.Reverse();

            foreach (var item in DigitsList)
            {
                Console.WriteLine(item);
            }

            return DigitsList;
        }

        public static int ListToNumber(List<int> digits)
        {
            string number = "";

            for (int i = 0; i < digits.Count; i++)
            {
                number = number + digits[i];
            }

            return int.Parse(number);
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Digits to list:");
            NumberToList(number);

            Console.Write("How many digits do you want to enter: ");
            int digitsToNumber = int.Parse(Console.ReadLine());

            List<int> Digits = new List<int>();

            for (int i = 0; i < digitsToNumber; i++)
            {
                Digits.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(ListToNumber(Digits));
        }
    }
}
