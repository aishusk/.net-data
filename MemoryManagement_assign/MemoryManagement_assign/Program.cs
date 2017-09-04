using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement_assign
{
    class Program
    {
        static void Main(string[] args)
        {
            //MemManage m = new MemManage();
            //m.fileIO();
            //m.Dispose();

            //Console.ReadLine();
            MemMgt2 m = new MemMgt2();
            m.fileIO();
            m.Dispose();
            Console.ReadLine();
        }
    }
}
