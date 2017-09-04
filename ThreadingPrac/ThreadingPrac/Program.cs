using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //Thread[] objThread = new Thread[4];
           Thread objThread1 = new Thread(p.divide);
           p.divide();
           // objThread.IsBackground = true;
            //objThread.Start();
            //objThread1.Start();
            //Console.WriteLine("Main app exit");
            //// Parallel.For(0, 1000000, x => Func());
            //for(int i=0;i<4;i++)
            //{
            //    objThread[i] = new Thread(Func);
            //    objThread[i].Name = "Thread" + i;
                

            //}
            //for(int i=0;i<4;i++)
            //{
            //    objThread[i].Start();
            //}
            Console.ReadLine();
        }
        static void Func()
        {
           
                Console.WriteLine("i am in {0}",Thread.CurrentThread.Name);
            Console.ReadLine();
         
          
            //Console.WriteLine("exiting function");
            //Console.ReadLine();
        }
        //static void Func1()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("in function 2");
                
        //    }
 

        //}
       public void divide()
        {
            int result = 0;
            Random r = new Random();
           
            lock (this)
            {
                
                for (int i = 0; i < 100000000; i++)
                {
                   int num1 = r.Next(1, 10);
                int num2 = r.Next(1, 10);

                    result = num1 / num2;
                    num1 = 0;
                    num2 = 0;
                    Console.WriteLine("result is{0}", result);

                }
            }

          
        }
     
    }
}
