using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que15
    {
        public void cube()
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=num;i++)
            {
                int cube = i * i * i;
                Console.WriteLine("cube of"+i+"is"+cube);
            }
            
        }
    }
}
