namespace ImplementStaticClassArrayExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            List<int> firstList = new List<int>() { 1, 2, 3 };
            List<int> secondList = new List<int>() { 3, 4, 5 };
            List<string> thirdList = new List<string>() { "a", "b", "v" };

            //var intersection = ArrayExtension.Intersect(firstList, secondList);
            //Console.WriteLine("Intersection: {0}", string.Join(", ", intersection));

            //var unionAll = ArrayExtension.UnionAll(firstList, secondList);
            //Console.WriteLine("UnionAll: {0}", string.Join(", ", unionAll));

            //var union = ArrayExtension.Union(firstList, secondList);
            //Console.WriteLine("Union: {0}", string.Join(", ", union));

            var join = ArrayExtension.Join(thirdList);
            Console.WriteLine("Join: {0}", join);


        }
    }
}
