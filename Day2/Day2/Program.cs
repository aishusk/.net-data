using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.duplicate();
            Console.ReadLine();
        }
        public void pattern()
        {
            Console.WriteLine("enter the number of rows");
           int a = Convert.ToInt32((Console.ReadLine()));
            for(int i=1;i<=a;i++)
            {
               
                for(int j=a;j>=i;j--)
                {
                    Console.Write(" ");

                }
                for (int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public void pallindrome()
        {
            Console.WriteLine("enter  string");
            string input = Console.ReadLine();
            int flag=0;
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]==input[input.Length-i-1])
                {
                    flag = 1;
                   
                
                }
                else
                {
                    flag = 0;
                    break;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("pallindrome");


            }
            else
            {
                Console.WriteLine("not a pallindrome");
            }

            }
        public void duplicate()
        {
            string SetenceString = "helloo helloo aishu aishu";
            var result = string.Join(" ", SetenceString.Split(' ').Distinct());
            Console.WriteLine(result);
            
        }
           
        }
    }
    

