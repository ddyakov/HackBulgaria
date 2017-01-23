using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates
{
    public delegate T AggregationDelegate<T>(T aggregate, T number);

    class Program
    {

        public static T AggregateCollection<T>(List<T> original, AggregationDelegate<T> aggregate)
        {
            T sum = original[0];

            for (int i = 0; i < original.Count; i++)
            {
                sum = aggregate(sum, original[i]);
            }

            return sum;
        }

        public static decimal Sum(decimal theSum, decimal currNumber)
        {
            return theSum += currNumber;
        }

        public static decimal Product(decimal theProduct, decimal currNumber)
        {
            return theProduct *= currNumber;
        }

        public static decimal Max(decimal theMax, decimal currNumber)
        {
            if (currNumber > theMax)
            {
                theMax = currNumber;
            }

            return theMax;
        }

        public static decimal Min(decimal theMin, decimal currNumber)
        {
            if (currNumber < theMin)
            {
                theMin = currNumber;
            }

            return theMin;
        }

        static void Main()
        {
            List<decimal> numbers = new List<decimal>() { 1, 2, 3, 4, 5 };
            var sumAggregate = AggregateCollection(numbers, Min);

            Console.WriteLine(sumAggregate);
        }
    }
}
