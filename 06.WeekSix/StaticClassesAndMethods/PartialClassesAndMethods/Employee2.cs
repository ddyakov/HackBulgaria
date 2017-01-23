using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public partial class Employee
    {
        partial void Print()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }

        public decimal CalculateAllIncome()
        {
            this.Print();
            return this.Salary + this.Bonus;
        }

        public decimal CalculateBalance()
        {
            return (this.Salary + this.Bonus) * (decimal)0.8;
        }
    }
}
