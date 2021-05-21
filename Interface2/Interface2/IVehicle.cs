using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface IVehicle
    {
        void changeGear(int newGear);
        void speedUp(int a);
        void applyBreaks(int a);
        int Add(int a, int b);
    }
}
