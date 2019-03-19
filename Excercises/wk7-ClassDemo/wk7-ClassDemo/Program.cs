using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk7_ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new instance
            //Pen sharpie = new Pen();
            //Pen lotus = new Pen();
            //Pen pilot = new Pen(3.20);

            //Console.WriteLine("The default price of ballpen is " + sharpie.getPrice());
            //Console.WriteLine("The default manufacturer of ballpen is " + sharpie.getYearofmanu());

            //sharpie.setPrice(2.99);
            //sharpie.setYearofmanu(2019);
            //Console.WriteLine("The new price of ballpen is " + sharpie.getPrice());
            //Console.WriteLine("The new manufacturer of ballpen is " + sharpie.getYearofmanu());

            //Console.WriteLine("The default price of ballpen is " + lotus.getPrice());
            //Console.WriteLine("The default manufacturer of ballpen is " + lotus.getYearofmanu());

            //Console.WriteLine("The default price of ballpen is " + pilot.getPrice());
            //Console.WriteLine("The default manufacturer of ballpen is " + pilot.getYearofmanu());
            //Console.ReadLine();

            Rectangle rect = new Rectangle();
            rect.setLength(10);
            rect.setWidth(15);
            Console.WriteLine($"Area of Rectangle {rect.getArea()}");
            Console.WriteLine($"Perimeter of Rectangle {rect.getPerimeter()}");

            // New Object with failing parameters
            Rectangle rect2 = new Rectangle();
            rect2.setLength(30);
            rect2.setWidth(60);
            Console.WriteLine($"Area of Rectangle {rect2.getArea()}");
            Console.WriteLine($"Perimeter of Rectangle {rect2.getPerimeter()}");

            Console.ReadLine();
        }
    }
}
