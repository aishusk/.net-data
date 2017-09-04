using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutexexamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var n = new Mutex(false, "Mutexexamp"))
            //{
            //    if(!n.WaitOne(5000,false))
            //    {
            //        Console.WriteLine("already instance running");
            //        Console.ReadLine();
            //        return;
            //    }
            //    Console.WriteLine("App is running");
            //    Console.ReadLine();
            //}
            if (!Program.isInstance())
            {
                Console.WriteLine("already instance running"); // Exit program.
            }
            else
            {
                Console.WriteLine("App is running"); // Continue with program.
            }
            // Stay open.
            Console.ReadLine();
        }
  
            public static bool isInstance()
        {
            try
            {
                Mutex.OpenExisting("instance");

            }
            catch
            {
                Mutex m = new Mutex(true, "instance");
                return true;
            }
            return false;
        }
            

        }
    }

