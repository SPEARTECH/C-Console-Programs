using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.AnimalSound();
            d1.sleep();
            Cat c1 = new Cat();
            c1.AnimalSound();
            Console.ReadLine();
        }

    }

}
