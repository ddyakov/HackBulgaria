using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        public static void Main()
        {
            var pr1 = new Product("Chai1", -1, 5);
            var pr2 = new Product("Chai2", 99, 5);
            var pr3 = new Product("Chai3", 25, 124);
            var pr4 = new Product("Chai4", 16, 102);
            var pr5 = new Product("Chai5", 5, 101);
            List<Product> products = new List<Product>() { pr1, pr2, pr3, pr4, pr5 };

            var c1 = new Category(5, "name1");
            var c2 = new Category(125, "name2");
            var c3 = new Category(124, "name3");
            var c4 = new Category(102, "name4");
            var c5 = new Category(111, "name5");
            var c6 = new Category(101, "name6");
            List<Category> categories = new List<Category>() { c1, c2, c3, c4, c5, c6 };

            List<int> prl1 = new List<int>() { 99, 4, 100, -1 };
            List<int> prl2 = new List<int>() { 4, 5, -1, 100 };
            List<int> prl3 = new List<int>() { 99, 4, 5 };
            List<int> prl4 = new List<int>() { 100, 91, 5 };

            var or1 = new Order("order1", 1, prl1, new DateTime(2001, 1, 1));
            var or2 = new Order("order2", 2, prl2, new DateTime(2000, 1, 2));
            var or3 = new Order("order3", 3, prl3, new DateTime(2000, 1, 3));
            var or4 = new Order("order5", 4, prl4, new DateTime(2000, 1, 8));
            var or5 = new Order("order6", 5, prl4, new DateTime(2000, 1, 7));
            var or6 = new Order("order4", 10, prl4, new DateTime(2000, 1, 6));
            var or7 = new Order("order14", 7, prl4, new DateTime(2000, 1, 14));
            var or8 = new Order("order11", 8, prl4, new DateTime(2000, 1, 24));
            var or9 = new Order("order9", 9, prl4, new DateTime(2000, 6, 4));
            var or10 = new Order("order7", 14, prl4, new DateTime(2000, 2, 4));
            var or11 = new Order("order12", 24, prl4, new DateTime(2000, 6, 4));
            var or12 = new Order("order8", 10, prl4, new DateTime(2000, 1, 5));
            var or13 = new Order("order15", 44, prl4, new DateTime(2000, 3, 4));
            var or14 = new Order("order13", 54, prl4, new DateTime(2000, 2, 4));
            var or15 = new Order("order10", 64, prl4, new DateTime(2000, 2, 4));
            var or16 = new Order("order17", 13, prl3, new DateTime(2000, 2, 4));
            List<Order> orders = new List<Order>() { or1, or2, or3, or4, or5, or6, or7, or8, or9, or10, or11, or12, or13, or14, or15, or16 };

            DateStore ds1 = new DateStore(orders, categories, products);

            //var productsId = from prod in products
            //                 where prod.Id > 15 && prod.Id < 30
            //                 select prod;

            //foreach (var item in productsId)
            //{
            //    Console.WriteLine(string.Format("Name: {0}, Id: {1}, CategoryId: {2}", item.Name, item.Id, item.CategoryId));
            //}

            //var categoriesId = from cat in categories
            //                   where cat.CategoryId > 105 && cat.CategoryId < 125
            //                   select cat;

            //foreach (var item in categoriesId)
            //{
            //    Console.WriteLine(string.Format("Name: {0}, CategoryId: {1}", item.CategoryName, item.CategoryId));
            //}

            //var sortedOrdersByName = from ord in orders
            //                         orderby ord.Name
            //                         select ord.Name;

            //Console.WriteLine(string.Join("\n", sortedOrdersByName.Take(15)));

            //var specificProduct = from ord in orders
            //                      where ord.Id == 10
            //                      orderby ord.OrderDate
            //                      select ord.Name;

            //Console.WriteLine(string.Join("\n", specificProduct.Take(3)));

            //var prodNameOfCat = from prod in products
            //                    join cat in categories
            //                    on prod.CategoryId equals cat.CategoryId
            //                    orderby cat.CategoryName
            //                    select new {CategoryName = cat.CategoryName, ProductName = prod.Name};

            //foreach (var item in prodNameOfCat)
            //{
            //    Console.WriteLine(item);
            //}

            //var prodsAndcats = from cats in categories
            //                   join prods in products
            //                   on cats.CategoryId equals prods.CategoryId
            //                   select new { CategoryName = cats.CategoryName, ProductName = prods.Name };

            //foreach (var item in prodsAndcats)
            //{
            //    Console.WriteLine(item);
            //}

            var ordsCatsAndProds = from ord in orders
                                   join cats in categories
                                   on ord.Id equals cats.CategoryId
                                   join prods in products
                                   on cats.CategoryId equals prods.CategoryId
                                   orderby ord.OrderDate
                                   select new { Orders = ord.Name, CategoryName = cats.CategoryName, ProductsName = prods.Name };

            foreach (var item in ordsCatsAndProds)
            {
                Console.WriteLine(item);
            }
        }
    }
}
