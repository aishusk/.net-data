using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("enter a string");
            //string str = Console.ReadLine();
            //Console.WriteLine(str.Upper() );
            //Console.WriteLine("please enter the type of vehicle spec u want to know \n 1.TwoWheeler 2.Four wheeler");
            //int option = Convert.ToInt32(Console.ReadLine());


            //    if (option == 1)
            //    {
            //        Ivehicle i = new TwoWheeler();
            //        i.specification();
            //    }
            //    else if (option == 2)
            //    {
            //        Ivehicle i = new FourWheeler();
            //        i.specification();
            //    }
            Console.WriteLine("enter length ");
            double length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            double breadth = Convert.ToInt32(Console.ReadLine());
            double result = Staticclass.area(length,breadth);
            Console.WriteLine("area is"+res);
               
             
            Console.ReadLine();
          }
    }
}
