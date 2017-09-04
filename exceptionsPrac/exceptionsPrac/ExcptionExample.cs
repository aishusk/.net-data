using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionsPrac
{
    class ExcptionExample
    {
        public void divison()
        {
            try
            {
                Console.WriteLine("Enter numbers for division");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int div = num1 / num2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("exception caught:{0}",e);
            }
         }
        
    }
}
