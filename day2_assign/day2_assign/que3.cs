using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que3
    {
        public void celcius_to_farenheit()
        {
            double celsius=0, fahrenheit;
            Console.WriteLine("enter celcius degree");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 1.8)+32;
            Console.WriteLine("farenheit value is "+fahrenheit);
        }
    }
}
