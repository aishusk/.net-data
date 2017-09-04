using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class Swap
    {
       public void swapNumbers()
        {
            Console.WriteLine("enter 1st numbr");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd numbr");
            int second = Convert.ToInt32(Console.ReadLine());
            first = first + second;
            second = first - second;
            first = first - second;
            Console.WriteLine("now first number is"+first);
            Console.WriteLine("now second number is" + second);

        }
    }
}
