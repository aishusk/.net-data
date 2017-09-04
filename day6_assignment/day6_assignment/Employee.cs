using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_assignment
{
   
       public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string DepartmentName { get; set; }
            public string ProjectName { get; set; }
        public static List<Employee> Emp_list = new List<Employee>();

        public Employee(int ID,string Name,string DepartmentName, string ProjectName)
        {
            this.ID = ID;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
            this.ProjectName = ProjectName;
            Emp_list.Add(this);
        }
        public void lambda()
        {
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            
            foreach (Employee val  in Emp_list.FindAll(e => (e.ID >= 6)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + val.Name + " \t\tID: " + val.ID);
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            
            if (Emp_list.Any(e => (e.ID >= 0 && e.ID <= 6)))
            {
                Console.WriteLine("Name : " +Name + " \t\tID: " + ID);
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            if (Emp_list.All(e => (e.ID <10)))
            {
                Console.WriteLine(  "  emp.ID"+ID);
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            if (Emp_list.Exists(e => e.Name == "samu"))
            {
                Console.WriteLine("yes it exists");
            }
            else
            {
                Console.WriteLine("does not exists");
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            foreach (Employee data in Emp_list.SkipWhile(e => e.ID > 6))
            {
                Console.WriteLine("Name : " + data.Name + " \t\tAge: " + data.ID);
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            
            Employee emp = Emp_list.Find(e => (e.ID == 4));
            Console.WriteLine("The person having ID '4' is : " + emp.Name + " \t\tID: " + emp.ID);
        }
        }

    }

