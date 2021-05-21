using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Car : IVehicle
    {
        int speed;
        int gear;

        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public void applyBreaks(int decrement)
        {
            int result = decrement - 5;

            speed = speed - result;
        }

        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        public void speedUp(int increment)
        {
            int result = increment * increment;
            speed = speed + increment;
        }
    }
}
