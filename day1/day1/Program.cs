using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {

            Derived1 d = new Derived1();
            d.display();
            Baseclass b = new Baseclass();
            b.display();
            Console.ReadLine();

            
        }
    }
}
