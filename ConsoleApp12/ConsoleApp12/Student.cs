using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Student
    {
        public string fName, lName, address, state, age, zipCode, visa;
 
        public Student()
        {
            this.fName = "";
            this.lName = "";
            this.address = "";
            this.state = "";
            this.age = "";
            this.zipCode = "";
            this.visa = "";
 
        }
 
        public Student(string fn, string ln, string adr, string st, string a, string zip, string vis)
        {
            this.fName = fn;
            this.lName = ln;
            this.address = adr;
            this.state = st;
            this.age = a;
            this.zipCode = zip;
            this.visa = vis;
        }
 
        public void DisplayInfo()
        {
            int fee = (state == "MO") ? fee = 12500-10000 : fee = 12500;
            Console.WriteLine(fName + " " + lName + "'s address is: " + address + ", " + state + ", " + zipCode + " and has " +
                                visa + " VISA. Fee: " + fee);
        }
    }
}
