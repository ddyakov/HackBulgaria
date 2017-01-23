using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace INotifyPropertyChanged
{
    public class Program
    {
        public static void Main()
        {
            Person boy = new Person();
            boy.PropertyChanged +=boy_propertyChanged;
            boy.FirstName = "Veche ne e mitko";
            boy.SecondName = "Goshev";
        }

        static void boy_propertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("HashCode: {0}", sender.GetHashCode());
            Console.WriteLine("Changed property:  {0}", e.PropertyName);
        }
    }
}
