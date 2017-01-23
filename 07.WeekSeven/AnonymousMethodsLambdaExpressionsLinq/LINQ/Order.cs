using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Order
    {
        public Order(string name, int id, List<int> products, DateTime orderDate)
        {
            this.Name = name;
            this.Id = id;
            this.Products = products;
            this.OrderDate = orderDate;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Products { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
