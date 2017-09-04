using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
   abstract class Abstract
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("animal can sound");
        }
    }
    class Dog:Abstract
    {
        public override void eat()
        {
            Console.WriteLine("dogs can eat");
        }
           


    }
}
