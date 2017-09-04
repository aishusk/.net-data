using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class Tables
    {
        public void table()
        {
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                int result = num * i;
                Console.WriteLine(num+"*"+i+"="+result);
            }
        }
    }
}
