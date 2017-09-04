using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado;

namespace DataFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new Employee1Entities())
            {
                //var emp = new Table_1();//table
                //emp.EmpID = 1;
                //emp.Name = "aishu";
                //emp.Salary = 100000;
                //EmpObj.Table_1.Add(emp);

                //var emp = new Table_1();//table
                // emp.EmpID = 2;
                // emp.Name = "amara";
                // emp.Salary = 100000;
                // EmpObj.Table_1.Add(emp);

                // emp = new Table_1();//table
                // emp.EmpID = 3;
                // emp.Name = "navpi";
                // emp.Salary = 100000;
                // EmpObj.Table_1.Add(emp);

                // emp = new Table_1();//table
                // emp.EmpID = 4;
                // emp.Name = "neel";
                // emp.Salary = 100000;
                // EmpObj.Table_1.Add(emp);

                // emp = new Table_1();//table
                // emp.EmpID = 5;
                // emp.Name = "rasika";
                // emp.Salary = 100000;
                // EmpObj.Table_1.Add(emp);

                //Table_1 obj = EmpObj.Table_1.First(i => i.EmpID == 1);
                //obj.Name = "babu";
                //obj.Salary = 450000;
                //EmpObj.SaveChanges();
                //EmpObj.SaveChanges();

                Table_1 obj = EmpObj.Table_1.First(i => i.EmpID == 2);
                EmpObj.Table_1.Remove(obj);
                Console.WriteLine("record deleted");
                EmpObj.SaveChanges();
            }
          
        }
    }
}
