using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithDatabase.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //public class EmpDBContext : DbContext
        //{
        //    public EmpDBContext()
        //    { }
        //    public DbSet<Employee> Employees { get; set; }
        //}
        [NonAction]
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>{
      new Employee{
         ID = 1,
         Name = "Allan",
        
         Age = 23
      },

      new Employee{
         ID = 2,
         Name = "Carson",
    
         Age = 45
      },

      new Employee{
         ID = 3,
         Name = "Carson",
        
         Age = 37
      },

      new Employee{
         ID = 4,
         Name = "Laura",
       
         Age = 26
      },
   };
        }
    }
}