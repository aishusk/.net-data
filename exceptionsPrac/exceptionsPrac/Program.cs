using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionsPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExcptionExample e = new ExcptionExample();
            //e.divison();
            //Console.ReadLine();
            Temperature t = new Temperature();
            try
            {
                t.temp(0);
            }
            catch(Customexcep e)
            {
                Console.WriteLine("exception{0}",e);
            }
            Console.ReadLine();
        }
    }
}
