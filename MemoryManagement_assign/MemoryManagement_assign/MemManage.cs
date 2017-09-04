using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement_assign
{
    class MemManage:IDisposable
    {
        public StreamWriter sw { get; set; }
        public StreamReader sr { get; set; }
        public void fileIO()
        {
             sw = new StreamWriter(@"D:\C#\22Aug_MemoryMgmt\abc.txt");
            sw.WriteLine("Memory management demo");
            sw.WriteLine("Memory management demo2");
            sw.Close();
             sr = new StreamReader(@"D:\C#\22Aug_MemoryMgmt\abc.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
           
        }


        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool v)
        {
            if (v)
            {
                Console.WriteLine("in dispose");
                GC.SuppressFinalize(this);
                 if(sw!=null)
            {
                sw.Dispose();
            }
            if(sr!=null)
            {
                sr.Dispose();
            }
            }
        }
    }
}
