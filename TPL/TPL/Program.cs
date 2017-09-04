using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(Func);
            t.Start();

        }
        public static void Func()
        {
            Console.WriteLine("in function");
        }
    }
}
