using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array creation
            int[] arr = new int[] { 1, 2 };
            int[,] arr1 = { { 3, 4 }, { 4, 5 } };//multidimentional

            int[][] arr2 = new int[2][];//jagged array

            arr[0] = 12;
            arr1[0, 1] = 4;

            arr2[0] = new int[2];
            arr2[1] = new int[2];
           // arr2[0] = new int[3];
            //tuples

            var info = new Tuple<string, string, string>("Aishu", ".net", "X5229");

            Console.WriteLine("arr"+arr2.Length);

            // Display author info  
            //Console.WriteLine("I am{0} and i am getting trained on {1} ,my employee code is{2}", info.Item1, info.Item2, info.Item3);

            for (int i=0;i<arr2.Length;i++)
            {
                for(int j=0;j<arr2[i].Length;j++)
                {
                    arr2[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                System.Console.Write("Element({0}): ", arr2[i]);

                for (int j = 0; j < arr2[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr2[i][j], j == (arr2[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}