using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    class Program
    {
        static void Main()
        {
            Employee a = new Employee();
            a.FirstName = "mitko";
            a.LastName = "dyakov";
            a.Bonus = 50;
            a.Salary = 500;

            Console.WriteLine(a.CalculateBalance());
            Console.WriteLine(a.CalculateAllIncome());
        }
    }
}
