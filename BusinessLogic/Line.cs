using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Line
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        private double _length;

        public Line(Point p1,Point p2)
        {
            this.Point1 = p1;
            this.Point2 = p2;
            this._length = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }

        public override string ToString()
        {
            return "\r\n"+"Отрезок с началом в точке " +Point1.ToString()+"и концом в точке "+Point2.ToString()+" длина "+_length.ToString()+" ";
        }

        }

    }
}
