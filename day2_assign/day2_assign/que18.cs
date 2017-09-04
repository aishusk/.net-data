using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que18
    {
        public void decimal_to_binary()
        {
            int quot;
            string rem = "";
            string bin = "";
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            while(num>=1)
            {
                quot = num / 2;
               
                rem =rem+ (num %2).ToString();
                num = quot;

            }
          
            for(int i=rem.Length-1;i>=0;i--)
            {
                bin = bin + rem[i];
               
            }
            Console.WriteLine(bin);
        }
    }
}
