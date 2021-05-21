using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine(Convert.ToString(car1.Add(4,5)));
            Bike bike1 = new Bike();
            bike1.speedUp(15);
            bike1.applyBreaks(4);
            bike1.changeGear(3);
            bike1.Display();
            Console.ReadLine();

        }
    }
}
