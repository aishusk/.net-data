using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class IsAsTest
    {
        int a = 10;
        public void isTest()
        {
            if (a is int)
            {
                Console.WriteLine("a is int");
            }
            else
                Console.WriteLine("a is not int");
            Console.WriteLine("size of int " + sizeof(int) + "and float" + sizeof(float));
        }
    }
    class derived : IsAsTest
    {
        public void asTest()
        {
            object[] arr = new object[5];
            arr[0] = 3;
            arr[1] = 5.3;
            arr[2] = "aishu";
            arr[3] = new IsAsTest();
            arr[4] = "minion";
            for (int i = 0; i < 5; i++)
            {
                string s = arr[i] as string;
                Console.WriteLine("{0}", i);
                if (s != null)
                {
                    Console.WriteLine(" string\t" + s + "");
                }
                else
                    Console.WriteLine("not a string");
                
            }
           
        }
    }
}

