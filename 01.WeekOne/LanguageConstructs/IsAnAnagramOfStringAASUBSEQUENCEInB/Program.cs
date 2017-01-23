using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAnAnagramOfStringAASUBSEQUENCEInB
{
    class Program
    {
        public static bool HasAnagramOf(string A, string B)
        {
            bool bContainsA = B.Contains(A);

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if(bContainsA)
                    {
                        bContainsA = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return bContainsA;
        }


        static void Main()
        {
            Console.Write("Enter first string: ");
            string input = Console.ReadLine();
            Console.Write("Enter second string: ");
            string input2 = Console.ReadLine();

            Console.WriteLine("Does it contain it: {0}",HasAnagramOf(input,input2));
        }
    }
}
