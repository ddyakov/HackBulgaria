using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;

namespace NotifyCollection
{
    public class Program
    {
        public static void Main()
        {
            NotifyCollection<int> list = new NotifyCollection<int>();
            list.Items = new List<int>() { 1, 2, 3, 4 };
            list.CollectionChanged += (s, e) => Console.WriteLine(e.PropertyName);  
            list.AddNumbers(6);
            list.RemoveNumber(2);
        }
    }

    
}
