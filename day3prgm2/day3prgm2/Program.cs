//using System.Diagnostics.CodeAnalysis;
using ClassMethodStaticDemo;

namespace Classmethoddemo
{
    internal class Program
    {
        static void display(ref int n)
        {
            n *= 20;
            Console.WriteLine("value in method"+n);
        }
        static void Outsample(out int n)
        {
            int a=20;
            n = a * 20;
            Console.WriteLine("value in method" + n);
        }
        static int division(int a,int b,out int r)
        {
            r = a % b;
            return a/b;
        }
        void show()
        {
            Console.WriteLine("Instance method");
        }
        int add(int a,int b)
        {
            return a + b;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Program p=new Program();
            p.show();
            int a = 20;
            Console.WriteLine("the value of a:" + a);
            display(ref a);
            Console.WriteLine("the value of a after calling:" + a);
            Console.WriteLine(p.add(10, 20));

            //out
            Outsample(out a);
            Console.WriteLine("the value after calling out:" + a);
            int res;
            Console.WriteLine(division(100, 5, out res));
            Console.WriteLine(res);
            Employee[] emp = new Employee[5];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter EmployeeId:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter EmployeeName:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Dept");
                string dpt = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                emp[i] = new Employee(id, name, dpt, sal);

            }
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i].EmpId + " " + emp[i].EmpName);

            }
        }
    }
}
