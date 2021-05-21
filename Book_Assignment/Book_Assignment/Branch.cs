using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Assignment
{
    class Branch
    {
        string branch1, branch2, branch3;

        public Branch()
        {
            this.branch1 = "St. Louis";
            this.branch2 = "Vegas";
            this.branch3 = "NYC";
        }

        public string getBranches()
        {
            return branch1 + "," + branch2 + "," + branch3;
        }

    }
}
