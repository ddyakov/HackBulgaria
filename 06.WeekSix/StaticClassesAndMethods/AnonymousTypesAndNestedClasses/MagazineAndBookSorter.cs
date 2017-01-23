using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypesAndNestedClasses
{
    public static class MagazineAndBookSorter
    {
        public static List<string> Sort(List<Book> books, List<Magazine> magazines)
        {
            var result = books.Select(x => new { x.Name, x.Id }).ToList();
            result.AddRange(magazines.Select(x => new {Name = x.Title, Id = x.ISBN}).ToList());
            result = result.OrderBy(x => x.Name).ThenBy(x => x.Id).ToList();
            return result.Select(x => x.Name).ToList();
        }
    }
}
