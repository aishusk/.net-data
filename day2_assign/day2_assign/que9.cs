using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que9
    {
        public void largest_number()
        {
            Console.WriteLine("enter 3 numbers");
            Console.WriteLine("enter 1st number");
            int first_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int second_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd number");
            int third_num = Convert.ToInt32(Console.ReadLine());
            if (first_num > second_num)
            {
                if (first_num > third_num)
                {
                    Console.WriteLine("First number is greatest");
                }
                else
                {
                    Console.WriteLine("third is greatest");
                }
            }
            else if (second_num > third_num)
            {
                Console.WriteLine("Second number is greatest ");
            }
            else
            {
                Console.WriteLine("third is greatest");
            }
        }
    }
}
