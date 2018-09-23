using System;

namespace BusinessLogic
{
    public class Square
    {
        private Line _line1;
        private Line _line2;
        private Line _line3;
        private Line _line4;

        public Square(Line l1,Line l2,Line l3,Line l4)
        {
            this._line1 = l1;
            this._line2 = l2;
            this._line3 = l3;
            this._line4 = l4;
        }

        public override string ToString()
        {
            return "\r\n"+"Квадрат со сторонами: " + _line1.ToString() + _line2.ToString() + _line3.ToString() + _line4.ToString();
        }

        public void SetTheSize(int size)
        {

        }


    }
}
