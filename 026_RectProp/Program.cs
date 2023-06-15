using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_RectProp
{
    public class Rectangle1
    {
        private double width;
        private double height;
    }
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 3;

            double area = rect.Width * rect.Height;
            double perimeter = 2 * (rect.Width + rect.Height);

            Console.WriteLine("넓이 : " + area);
            Console.WriteLine("둘레 : " + perimeter);
        }
    }
}
