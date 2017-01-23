namespace ImplementStaticClassArrayExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ArrayExtension
    {
        public static List<T> Intersect<T>(this List<T> firstList, List<T> secondList)
        {
            List<T> intersection = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i].Equals(secondList[j]))
                    {
                        intersection.Add(firstList[i]);
                    }
                }
            }

            return intersection;
        }

        public static List<T> UnionAll<T>(List<T> firstList, List<T> secondList)
        {
            List<T> unionAll = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                unionAll.Add(firstList[i]);
            }

            for (int j = 0; j < secondList.Count; j++)
            {
                unionAll.Add(secondList[j]);
            }

            return unionAll;
        }

        public static List<T> Union<T>(List<T> firstList, List<T> secondList)
        {
            List<T> union = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                union.Add(firstList[i]);
            }

            for (int j = 0; j < secondList.Count; j++)
            {
                if (!(union.Contains(secondList[j])))
                {
                    union.Add(secondList[j]);
                }
            }

            return union;
        }

        public static string Join(List<string> list)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                if (i + 1 != list.Count)
                {
                    output.Append(string.Format(list[i] + Configuration.Replace));
                }
                else
                {
                    output.Append(list[i]);
                }
            }

            return output.ToString();
        }
    }
}
