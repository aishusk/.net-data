using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    static class ExtensionMethod
    {
        public static void display(this Object ob)
        {
            Console.WriteLine("in extension method");
            Console.WriteLine(ob);
            
        }
        public static int stringToint(string num)
        {
            int num1 = Convert.ToInt32(num);
            return num1;
        }
         
    }
}
