using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_RectangleClass
{
    public class Rectangle
    {
        private double Height;
        private double Width;
        public Rectangle(double h, double w)
        {
            this.Height = h;
            this.Width = w;
        }
        public double GetArea()
        {
            return Height*Width;
        }
        public double GetPerimeter()
        {
            return 2*(Width+Height);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);
            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();
            
            Console.WriteLine("넓이 : " +  area);
            Console.WriteLine("둘레 : " + perimeter);
        }
    }
}
