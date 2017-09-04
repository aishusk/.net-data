using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que6
    {
        public void sum_of_digits()
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int sum = 0;
           while(num>0)
            {
                rem = num % 10;
                num = num / 10;
                sum += rem;


            }
            Console.WriteLine("sum of number is "+sum);

        }
    }
}
