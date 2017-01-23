using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Point
    {
        private double x;
        private double y;

        public Point(double xCoo, double yCoo)
        {
            this.X = xCoo;
            this.Y = yCoo;
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(Point coordinates)
        {
            this.x = coordinates.x;
            this.y = coordinates.y;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            private set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            private set
            {
                this.y = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Point({0},{1})", this.x, this.y);
        }

        public override bool Equals(object obj)
        {
            if (this.x == (obj as Point).x && this.y == (obj as Point).y)
            {
                return true;
            }

            return false;
         }

        public static bool operator ==(Point obj1, Point obj2)
        {
            if (obj1.x == obj2.x && obj1.y == obj2.y)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Point obj1, Point obj2)
        {
            if (obj1.x == obj2.x ^ obj1.y == obj2.y)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }

        public static LineSegment operator +(Point obj1, Point obj2)
        {
            LineSegment result = new LineSegment(obj1, obj2);

            return result;
        }
    }
}
