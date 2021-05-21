using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Assignment
{
    class Customer
    {
        Dictionary<string,string> customers = new Dictionary<string, string>();

        public Customer(string customer, string title)
        {
            this.customers.Add(customer, title);
        }

        public string getCustomerBooks(string username)
        {
            string outVar = "";
            foreach (string item in customers.Keys)
            {
                if (item.Equals(username))
                {
                    outVar = outVar + customers[username] + "\n";
                }
            }
            return outVar;        
        }
    }
}
