using System.Drawing;
using System;

namespace BusinessLogic
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point()
        {    
     
        }

        public virtual void Draw(Bitmap bmp,Color color)
        {
            bmp.SetPixel(X, Y,color);
        }

    }
}
