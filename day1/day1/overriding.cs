using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class Baseclass
    {
        public virtual void display()
        {
            Console.WriteLine("this is base class");
        }
    }
    class Derived1 : Baseclass
    {
        public override void display()
        {
            Console.WriteLine("this is derived 1");
        }
    }


}
