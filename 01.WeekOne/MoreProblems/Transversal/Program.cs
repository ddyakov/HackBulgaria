using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transversal
{
    class Program
    {
        public static bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
            bool isTransveralNum = false;

            foreach (var subList in family)
            {
                isTransveralNum = false;
                for (int i = 0; i < transversal.Count; i++)
                {
                    if (subList.Contains(transversal[i]))
                    {
                        isTransveralNum = true;
                        break;
                    }
                }
                if (!isTransveralNum)
                {
                    return false;
                }
            }

            return isTransveralNum;
        }

        static void Main()
        {
            List<int> transverals = new List<int>();
            transverals.Add(4);
            transverals.Add(5);
            transverals.Add(6);

            //transverals.Add(1);
            //transverals.Add(2);

            //transverals.Add(2);
            //transverals.Add(3);
            //transverals.Add(4);

            List<List<int>> familyList = new List<List<int>>();
            familyList.Add(new List<int>() { 5, 7, 9 });
            familyList.Add(new List<int>() { 1, 4, 3 });
            familyList.Add(new List<int>() { 2, 6 });

            //familyList.Add(new List<int>() { 1, 5 });
            //familyList.Add(new List<int>() { 2, 3 });
            //familyList.Add(new List<int>() { 4, 7 });

            //familyList.Add(new List<int>() { 1, 7 });
            //familyList.Add(new List<int>() { 2, 3, 5 });
            //familyList.Add(new List<int>() { 4, 8 });

            Console.WriteLine(IsTransversal(transverals, familyList));

        }
    }
}
