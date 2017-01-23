using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class DateStore
    {
        private readonly List<Product> products;
        private readonly List<Order> orders;
        private readonly List<Category> categories;

        public DateStore(List<Order> orders, List<Category> categories, List<Product> products)
        {
            this.orders = orders;
            this.categories = categories;
            this.products = products;
        }

        public List<Product> GetProducts()
        {
            return this.products.Where(x => x.Id < 100 && x.Id > 1).ToList();
        }

        public List<Category> GetCategories()
        {
            return this.categories.Where(x => x.CategoryId > 101 && x.CategoryId < 200).ToList();
        }

        public List<Order> GetOrders()
        {
            return this.orders.Where(x => x.Id > 201 && x.Id < 300).ToList();
        }
    }
}
