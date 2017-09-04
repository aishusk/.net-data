using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement_assign
{
    class MemMgt2
    {
        public void fileIO()
        {
            string[] input = { "i", "am", "aishu" };
            using (StreamWriter sw = new StreamWriter(@"D:\C#\22Aug_MemoryMgmt\abc1.txt"))
            {
                foreach (string item in input)
                {
                    sw.WriteLine(item);

                }

            }

            string line = "";
            using (StreamReader sr = new StreamReader(@"D:\C#\22Aug_MemoryMgmt\abc1.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
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
            }
        }
    }
    }

