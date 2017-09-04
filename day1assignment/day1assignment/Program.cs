using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e;
            e = new Manager("aishu", "Manager");
            e.calSalary();
            e = new Clerk("rasika", "clerk");
            e.calSalary();
            Console.ReadLine();
        }
    }
}
