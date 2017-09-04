using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 300000;
            //int j = 400000;
            //try
            //{
            //    Console.WriteLine(checked(i * j));
            //}
            //catch(System.OverflowException e)
            //{
            //    Console.WriteLine("Checked"+e.ToString());
            //}
            //Console.WriteLine("size of double"+sizeof(double));
            //Console.WriteLine("size of bool" + sizeof(bool));
            //Console.WriteLine("type of"+typeof(double));
            //Console.WriteLine((2*3+7));

            //IsAsTest b;
            //b = a;
            //bool c = Object.ReferenceEquals(a, b);
            //Console.WriteLine(c);
            //string str1 = "abc";
            //string str2 = "abc";
            //StringBuilder str3 = new StringBuilder("abc");
            //Console.WriteLine("equals"+object.Equals(str1,str2));
            //Console.WriteLine("reference equals"+object.ReferenceEquals(str1,str3));
            //Console.WriteLine(str1==str2);
            //a.asTest();
            
            IsAsTest d = new derived();
            d.asTest();
           
            derived b = (derived)new IsAsTest();
           
            Console.ReadLine();
        }
    }
}
