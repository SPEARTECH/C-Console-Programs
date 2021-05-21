using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rect = new Rectangle(12,12);
            //Rectangle.sum();
            //Figure.add();
            //rect.hello();

            Circle circle = new Circle(12.12, 12.12);
            //Console.WriteLine(circle.GetArea());
            //circle.hello();

            //Triangle triangle = new Triangle(24.24,12.12);
            //Console.WriteLine(triangle.GetArea());
            //triangle.hello();

            circle.GetParameter();

            Console.ReadLine();
        }
    }
}
