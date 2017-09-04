using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que8
    {
        public void leap_years()
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%400==0)
            {
                Console.WriteLine("it is a leap year") ;
            }
            else if(year%100==0)
            {
                Console.WriteLine("not a leap year");
            }
            else if(year%4==0)
            {
                Console.WriteLine("it is a leap year") ;
            }
            else
            Console.WriteLine("not a leap year") ;
        }
        
    }
}
