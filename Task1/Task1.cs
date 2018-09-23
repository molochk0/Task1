using System.Drawing;
using System.Windows.Forms;
using BusinessLogic;
using System.Drawing.Drawing2D;

namespace Task1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Rotate(float angle,PaintEventArgs e)
        {
            Matrix myMatrix = new Matrix();
            myMatrix.Rotate(angle);
            e.Graphics.Transform = myMatrix;
        }
        private void Task1_Paint(object sender, PaintEventArgs e)
        {
            BusinessLogic.Point p1 = new BusinessLogic.Point(50, 20);
            BusinessLogic.Point p2 = new BusinessLogic.Point(150, 20);
            BusinessLogic.Point p3 = new BusinessLogic.Point(50, 120);
            BusinessLogic.Point p4 = new BusinessLogic.Point(150, 120);

            BusinessLogic.Point p111 = new BusinessLogic.Point(10, 200);
            BusinessLogic.Point p222 = new BusinessLogic.Point(60, 300);

            BusinessLogic.Line l = new Line(p111, p222);

            BusinessLogic.Point p11 = new BusinessLogic.Point(200, 100);
            BusinessLogic.Point p22 = new BusinessLogic.Point(300, 100);
            BusinessLogic.Point p33= new BusinessLogic.Point(200, 200);
            BusinessLogic.Point p44 = new BusinessLogic.Point(300, 200);
           
            BusinessLogic.Square square2 = new Square(p1,p2,p3,p4);
            BusinessLogic.Square square22 = new Square(p11, p22, p33, p44);

            Bitmap bmp = new Bitmap(e.ClipRectangle.Width, e.ClipRectangle.Height);
            Color color = new Color();
            color = Color.Red;
           // square2.Compress(3);
           // square2.SetLength(70);

            //square2.Draw(bmp, Color.Blue);
           // square22.Stretch(3);
            square22.Draw(bmp, color);
            Rotate(40,e);
            e.Graphics.DrawImage(bmp,e.ClipRectangle);
            bmp.Dispose();
        }
    }
}
