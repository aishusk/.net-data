using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewADO;

namespace NewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DeptContext())
            {
               
                var deptobj = new Department { DeptID = 1, Name = "aishu", Location = "pune" };
                dept.Departments.Add(deptobj);
                dept.SaveChanges();
                Console.WriteLine("added");
            }
        }
    }
}
