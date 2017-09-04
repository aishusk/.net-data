using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPool1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Func);
            ThreadPool.QueueUserWorkItem(Func1);
            Console.ReadLine();

        }
        static void Func(object obj)
        {

            Console.WriteLine("i am in function 1 {0}", Thread.CurrentThread.Name);
            Console.ReadLine();


            //Console.WriteLine("exiting function");
            //Console.ReadLine();
        }
        static void Func1(object obj)
        {

            Console.WriteLine("i am in function 2 {0}", Thread.CurrentThread.Name);
            Console.ReadLine();


            //Console.WriteLine("exiting function");
            //Console.ReadLine();
        }
    }
}
