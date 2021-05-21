using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Bike : IVehicle
    {
        int speed = 0;
        int gear;

        public void applyBreaks(int a)
        {
            if (speed == 0)
            {

            }
            else
            {

            speed = speed - a;
            }
        }

        public void changeGear(int newGear)
        {
            
            gear = newGear;
        }

        public void speedUp(int a)
        {
            speed = speed + a;
        }

        public void Display()
        {
            Console.WriteLine("Your speed is: "+speed);
        }

        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
