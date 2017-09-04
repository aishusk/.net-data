using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_assignment
{
    interface Ivehicle
    {
        void specification();
    }

    class Vehicle:Ivehicle
    {
       
        public void specification()
        {
            Console.WriteLine("Vehicle is Hyundai i10 and is red in color ");
        }
    }
    class TwoWheeler : Ivehicle
    {
        public void specification()
        {
            Console.WriteLine("Vehicle is Honda Activa and is yellow in color");
        }
    }
    class FourWheeler : Ivehicle
    {
        public void specification()
        {
            Console.WriteLine("Vehicle is  Hyundai i20 and is blue in color");
        }
    }
}
