using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Property
{
    internal class Rectangle  // 조건이 없을때 prop
    {
        // prop Tap 두번
        public double Width { get; set; } //; 세미콜론 옶다
        public double Height { get; set; }
    }

    public class Ractangle2  // 조건이 있으면 propfull
    {
        // propfull  Tap 두번
        private double width;
        public double Width
        {
            get { return width; }
            set { if(value > 0) width = value; }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { if(value > 0) height = value; }
        }
    }
}
