using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    interface IEmployee
    {
      void display();
     void CalSal();
    }

    class FullTimeEmp:IEmployee
    {
       public void display()
        {
            Console.WriteLine("Hello Employee");
        }
        public void CalSal()
        {
            Console.WriteLine("Your sal is bla bla");
        }
    }
}
