using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Square:Line
    {

        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }
        public Point P4 { get; set; }

        private Line _line1;
        private Line _line2;
        private Line _line3;
        private Line _line4;


        public Square(Point p1, Point p2, Point p3, Point p4)
        {

            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
            this.P4 = p4;
            this._line1 = new Line(p1, p2);
            this._line2 = new Line(p1, p3);
            this._line3 = new Line(p3, p4);
            this._line4 = new Line(p2, p4);
        }


        public override void Draw(Bitmap bmp,Color color)
        {
            _line1.Draw(bmp,color);
            _line2.Draw(bmp, color);
            _line3.Draw(bmp, color);
            _line4.Draw(bmp, color);
        }

        public override void Stretch(int size)
        {
            _line1.Stretch(size);
            _line2.Stretch(size);
            _line3.Stretch(size);
            _line4.Stretch(size);
            _line3.Point2.X = _line1.Point2.X;
            _line3.Point2.Y = _line2.Point2.Y;
            _line4.Point2.X = _line1.Point2.X;
            _line4.Point2.Y = _line2.Point2.Y;

        }

        public override void Compress(int size)
        {
            _line1.Compress(size);
            _line2.Compress(size);
            _line3.Compress(size);
            _line4.Compress(size);
            _line3.Point2.X = _line1.Point2.X;
            _line3.Point2.Y = _line2.Point2.Y;
            _line4.Point2.X = _line1.Point2.X;
            _line4.Point2.Y = _line2.Point2.Y;

        }

        public void SetLength(int l)
        {
            _line1.Point2.X = _line1.Point1.X + l;
            _line2.Point2.Y = _line2.Point1.Y + l;
            _line3.Point2.X = _line3.Point1.X + l;
            _line3.Point2.Y = _line1.Point2.Y + l;
        }

    }
}
