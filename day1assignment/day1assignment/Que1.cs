using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1assignment
{
    abstract class Bird
    {
        public abstract void display();
        public void walk()
        {
            Console.WriteLine("i can walk");
        }

    }
    class First:Bird
    {
        public override void display()
        {
            Console.WriteLine("I can fly ");
            walk();
        }
        
    }
    class Second : Bird
    {
        public override void display()
        {
            Console.WriteLine("I can sing ");
            walk();
        }
    }

    }



