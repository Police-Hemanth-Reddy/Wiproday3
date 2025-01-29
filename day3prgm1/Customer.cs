using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3prgm1
{
    internal class Customer
    {
        public int cust_id;
        public string cust_name;
        public Customer(int id, string name)
        {
            cust_id = id;
            cust_name = name;
        }
        public void display()
        {
            Console.WriteLine($"customerid { cust_id} customer name {cust_name}");
        }
    }
}
