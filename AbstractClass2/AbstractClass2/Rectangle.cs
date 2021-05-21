using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    public class Rectangle : Figure
    {
        public Rectangle(double width,double height)
        {
            this.width = width;

        }
        //public override double GetArea()
        //{
        //    return width * height;
        //}
        //public static void sum()
        //{
        //    Console.WriteLine("This is sum method");
        //}

        //public override void hello()
        //{
        //    Console.WriteLine("Hello");
        //}
    }
}
