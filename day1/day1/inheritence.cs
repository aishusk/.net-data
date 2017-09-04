using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    public class Car
    {
        public void type()
        {
            Console.WriteLine("This is a car");
        }
    }
   public class Honda:Car
    {
        public void hondaCar()
        {
            Console.WriteLine("Honda City");
            type();         
        }
    }
    public class Tata : Car {
        public void tataCar()
        {
            Console.WriteLine("Tata Tiago");
            type();

        }
    }

}
