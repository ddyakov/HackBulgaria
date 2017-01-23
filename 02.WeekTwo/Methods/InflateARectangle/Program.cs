using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InflateARectangle
{
    class Program
    {
        public static void Inflate(ref Rectangle rect, Size inflateSize)
        {
            rect.X -= inflateSize.Width;
            rect.Y -= inflateSize.Height;
            rect.Width += inflateSize.Width*2;
            rect.Height += inflateSize.Height*2;
        }

        static void Main()
        {
            Rectangle rect = new Rectangle (  0, 0, 10, 10 );
            Size size = new Size(2, 2);
            Inflate(ref rect, size);
            Console.WriteLine(rect);
        }
    }
}
