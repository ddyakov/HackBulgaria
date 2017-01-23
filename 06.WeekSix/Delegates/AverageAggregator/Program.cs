using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AverageAggregator;
using System.ComponentModel;

namespace AverageAggregator
{
    public class Program
    {
        public static void Main()
        {
            AverageAggregator a = new AverageAggregator();
            a.PropertyChanged += (s, e) => Console.WriteLine(e.PropertyName);
            a.AddNumber(6);
            a.AddNumber(3);
            Console.WriteLine(a.Average);
        }
    }
}