using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk7_ClassDemo
{
    class Pen
    {
        //define the properties of the class
        private double price;
        private int yearofmanu;

        //define a default constructor  //Assesor = public protected and private
        public Pen()
        {
            price = 3.00;
            yearofmanu = 2019;
            Console.WriteLine("New Pen Created.");
        }

        public Pen(double p)
        {
            price = p;
            Console.WriteLine("New Pen Created using parameterized constructor.");
        }

        public void setPrice(double p)
        {
            price = p;
        }
        public double getPrice()
        {
            return price;
        }

        public void setYearofmanu(int y)
        {
            yearofmanu = y;
        }

        public int getYearofmanu()
        {
            return yearofmanu;
        }
    }
}
