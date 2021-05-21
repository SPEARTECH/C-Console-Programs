using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class Circle:Figure
    {
        public static double pHeight = 0;

        public Circle(double height, double radius)
        {
            this.height = height;
            this.radius = radius;
            pHeight = 10;

        }
        //public Circle(double height)
        //{
        //    this.height = height;
        //}
        //public override double GetArea()
        //{
        //    double area = this.height * this.radius;
        //    return area;
        //}

        //public override void hello()
        //{
        //    Console.WriteLine("This is the Circle hello override method");
        //}

        public void GetParameter()
        {
            double perimeter = pHeight * 2;
            Console.WriteLine(perimeter);
        }
    }
}
