using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Category
    {
        public Category(int Id, string Name)
        {
            this.CategoryId = Id;
            this.CategoryName = Name;
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
