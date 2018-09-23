using System;
using System.Drawing;

namespace BusinessLogic
{
    public class Line:Point
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public double Length { get; set; }

        public Line(Point p1,Point p2)
        {
            if ((CheckX(p1.X, p2.X)==false)&&(p1.Y>p2.Y))
            {
                this.Point1 = p2;
                this.Point2 = p1;

                /*int temp = p1.X;
                p1.X = p2.X;
                p2.X = temp;
                temp = p1.Y;
                p1.Y = p2.Y;
                p2.Y = temp;*/
            }
            else
            {
                this.Point1 = p1;
                this.Point2 = p2;
                this.Length = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            }
            
        }

        public Line()
        {

        }

        public virtual void Stretch(int size)
        {
            if(Point2.Y==Point1.Y)
            {
                Length *= size;
                int t = Point1.X;
                Point2.X = Math.Abs(Point2.X-Point1.X)*size+t;
            }

            if (Point2.X==Point1.X)
            {
                Length *= size;
                int t = Point1.Y;
                Point2.Y = Math.Abs(Point2.Y-Point1.Y)*size+t;
            }
        }

        public virtual void Compress(int size)
        {
            if (Point2.Y == Point1.Y)
            {
                Length /= size;
                int t = Point1.X;
                Point2.X = Math.Abs(Point2.X - Point1.X) / size +t;
            }

            if (Point2.X == Point1.X)
            {
                Length /= size;
                int t = Point1.Y;
                Point2.Y = Math.Abs(Point2.Y - Point1.Y) / size +t;
            }
        }

      

        private bool CheckX(int x1,int x2)
        {
            if (x2 >= x1)
                return true;
            else return false;
        }

        public override void Draw(Bitmap bmp,Color color)
        {
            int dx = Point2.X - Point1.X;
            int dy = Point2.Y - Point1.Y;
            int d = 0;
            int d1 = dy*2;
            int d2 = -(dx*2);
            bmp.SetPixel(Point1.X+1,Point1.Y,color);
            int x = Point1.X;
            int y = Point1.Y;

            for (int i = 1; i <= dx + dy; i++)
            {
                if (d > 0)
                {
                    d += d2;
                    y++;
                }
                else
                {
                    d += d1;
                    x++;
                }
                bmp.SetPixel(x, y, color);
            }
        }

    }

}

    

