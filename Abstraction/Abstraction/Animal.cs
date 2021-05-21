using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public void sleep()
        {
            Console.WriteLine("Szzzzz");
        }
        public abstract void AnimalSound();
    }
}
