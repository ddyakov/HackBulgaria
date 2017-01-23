using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        static void Main()
        {
            Point obj1 = new Point(1, 1);
            Point obj2 = new Point(1, 14);
            Point obj3 = new Point(20, 3);
            Point obj4 = new Point(16, 6);

            LineSegment liniq = new LineSegment(obj1, obj2);
            LineSegment liniq2 = new LineSegment(obj3, obj4);

            double length = 13;

            Console.WriteLine(obj1 + obj2);

        }
    }
}
