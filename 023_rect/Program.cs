using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_rect
{
    public class Rectangle
    {
        private double w;
        private double h;

        public Rectangle(double w, double h)
        {
            this.w = w;
            this.h = h;
        }
        public Rectangle(double x)
        {
            this.w = x;
            this.h = x;
        }

        public double GetArea()
        {
            return w * h;
        }
        public double GetPerimeter()
        {
            return 2*(w + h);
        }
    }
    public class Circle
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public double GetCircleArea()
        {
            return r * r * 3.14;
        }
        public double GetCirclePerimeter()
        {
            return r * 2 * 3.14;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {            
            Rectangle rect = new Rectangle(3, 5);
            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            Rectangle rect2 = new Rectangle(3);
            double area2 = rect2.GetArea();
            double perimeter2 = rect2.GetPerimeter();

            Circle r = new Circle(3);
            double CArea = r.GetCircleArea();
            double CPerimeter = r.GetCirclePerimeter();

            Console.WriteLine("area : {0}, perimeter : {1}", area, perimeter);
            Console.WriteLine("area2 : {0}, perimeter2 : {1}", area2, perimeter2);
            Console.WriteLine("원의 넓이 : {0}, 원의 둘레 : {1}", CArea, CPerimeter);
        }
    }
}
