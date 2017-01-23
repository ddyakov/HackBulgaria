using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class LineSegment
    {
        private Point start;
        private Point end;
        private double length;

        public LineSegment(Point start, Point end)
        {
            if (start == end)
            {
                throw new ArgumentException("Cannot create a line segment with zero length");
            }

            this.Start = start;
            this.End = end;
            this.length = GetLength();
        }

        public static LineSegment CopyConstructor(LineSegment line)
        {
            LineSegment Line = new LineSegment(line.start, line.end);

            return Line;
        }

        public Point Start
        {
            get
            {
                return this.start;
            }
            private set
            {
                this.start = value;
            }
        }

        public Point End
        {
            get
            {
                return this.end;
            }
            private set
            {
                this.end = value;
            }
        }

        public double GetLength()
        {
            this.length = Math.Pow(Math.Max(this.start.X, this.end.X) - Math.Min(this.start.X, this.end.X), 2) +
                Math.Pow(Math.Max(this.start.Y, this.end.Y) - (Math.Min(this.start.Y, this.end.Y)), 2);

            return Math.Sqrt(length);
        }

        public override string ToString()
        {
            string result = "Line[(" + this.start.X + "," + this.start.Y + "), (" +
                this.end.X + "," + this.end.Y + ")]";

            return result;
        }

        public override bool Equals(object obj)
        {
            if (this.length == (obj as LineSegment).length)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(LineSegment obj1, LineSegment obj2)
        {
            if (obj1.start.X == obj2.start.X && obj1.end.Y == obj2.end.Y)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(LineSegment obj1, LineSegment obj2)
        {
            if (obj1.start.X == obj2.start.X ^ obj1.end.Y == obj2.end.Y)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(LineSegment obj1, LineSegment obj2)
        {
            if (obj1.length < obj2.length)
            {
                return true;
            }

            return false;
        }

        public static bool operator >(LineSegment obj1, LineSegment obj2)
        {
            if (obj1.length > obj2.length)
            {
                return true;
            }

            return false;
        }

        public static bool operator <=(LineSegment obj1, LineSegment obj2)
        {
            if (obj1.length <= obj2.length)
            {
                return true;
            }

            return false;
        }

        public static bool operator >=(LineSegment obj1, LineSegment obj2)
        {
            if (obj1.length >= obj2.length)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(LineSegment obj1, double givenLength)
        {
            if (obj1.length < givenLength)
            {
                return true;
            }

            return false;
        }

        public static bool operator >(LineSegment obj1, double givenLength)
        {
            if (obj1.length > givenLength)
            {
                return true;
            }

            return false;
        }

        public static bool operator <=(LineSegment obj1, double givenLength)
        {
            if (obj1.length <= givenLength)
            {
                return true;   
            }

            return false;
        }

        public static bool operator >=(LineSegment obj1, double givenLength)
        {
            if (obj1.length >= givenLength)
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
                hash = hash * 23 + start.GetHashCode();
                hash = hash * 23 + end.GetHashCode();
                return hash;
            }
        }
    }
}
