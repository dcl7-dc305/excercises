using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk7_ClassDemo
{
    class Rectangle
    {
        private float length;
        private float width;

        public Rectangle()
        {
            length = 10;
            width = 20;
            Console.WriteLine("\nRectangle has been created.");
        }

        public void setLength(float l)
        {
            if (l >= 0 && l <= 20.0)
            {
                length = l;
                Console.WriteLine($"Length = {length}");
            }
            else
            {
                Console.WriteLine("ERROR: Length should be greater 0 or less than 20 value. Length will be set to 10.");
                length = 10;
            }

        }
        public void setWidth(float w)
        {
            if (w >= 0 && w <= 20.0)
            {
                width = w;
                Console.WriteLine($"width = {width}");
            }
            else
            {
                Console.WriteLine("ERROR: Width should be greater 0 or less than 20 value. Width will be set to 20");
                width = 20;
            }
        }

        public float getArea()
        {
            return length * width;
        }

        public float getPerimeter()
        {
            return 2 * (length + width);
        }
    }
}
