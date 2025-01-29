using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3prgm1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("enter the Poductid");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the productname:");
            string nm=Console.ReadLine();
            Product p=new Product(id,nm);
            p.publicmethod();
            Console.WriteLine("enter the Poductid");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the productname:");
            string nm1 = Console.ReadLine();
            Customer c=new Customer(id1,nm1);
            c.display();
            
        }
    }
}
