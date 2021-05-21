using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Hey Im a Cat!");
        }
    }
}
