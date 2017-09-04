using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class Overloading
    {
        public void sum()
        {

            Console.WriteLine("no value provided");
        }
        public int sum(int x, int y)
        {
            
            return x + y;
        }
        public float sum(float x,int y)
        {
            return x + y;
            
        }
        public float sum(float x, float y)
        {
            return x + y;

        }
    }
}
