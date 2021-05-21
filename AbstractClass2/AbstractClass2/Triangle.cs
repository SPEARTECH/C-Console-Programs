using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class Triangle : Figure
    {
        public Triangle(double height, double width)
        {
            this.height = height;
            this.width = width;

        }
        //public override double GetArea()
        //{
        //    double area = this.height * this.width;
        //    return area;
        //}

        //public override void hello()
        //{
        //    Console.WriteLine("This is the Triangle hello override method");
        //}

    }
}
