using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que2
    {
        public void print_rectangle()
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0}  {0}", number);
            Console.WriteLine("{0}  {0}", number);
            Console.WriteLine("{0}  {0}", number);
            Console.WriteLine("{0}{0}{0}", number);

        }
    }
}
