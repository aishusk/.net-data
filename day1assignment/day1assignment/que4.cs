using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1assignment
{
    class Employee
    {
        string name;
        string position;
    public double salary=1000;
        public Employee(string name,string position)
        {
            this.name = name;
            this.position = position;
            
        }
        public virtual void calSalary()
        {
            Console.WriteLine("Salary of Manager is:" + (salary ));
        }



    }
    class Manager:Employee
    {
        public Manager(string name, string position) :base(name,position)
        {
            
        }
            
        public override void calSalary()
        {
            Console.WriteLine("Salary of Manager is:" + (salary * 500));
        }
    }
    class Clerk : Employee
    {
        public Clerk(string name, string position) :base(name,position)
        {

        }
        public override void  calSalary()
        {
            Console.WriteLine("Salary of Clerk is:" + (salary * 200));
        }
    }
}
