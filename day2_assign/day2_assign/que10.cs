using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que10
    {
        public void temp()
        {
            int tmp;
            Console.WriteLine("enter the temperature");

            
            tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp < 0)
                Console.Write("Freezing weather");
            else if (tmp < 10)
                Console.Write("Very cold weather");
            else if (tmp < 20)
                Console.Write("Cold weather");
            else if (tmp < 30)
                Console.Write("Normal in temp");
            else if (tmp < 40)
                Console.Write("Its Hot");
            else
                Console.Write("Its very hot");
        }
    }
}
