using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class InvalidChoice : Exception {
        public InvalidChoice(string msg):base(msg){

        }
    }

    class MathLib
    {

        public void MathOperation()
        {
            int result = 0;
            char ans = 'n';
            
            do {
                Console.WriteLine("enter two numbers");

                int num1 = 0;
                int num2 = 0;
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());

                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("ENTER YOUR CHOICE");
                Console.WriteLine("1.Add \n 2.Subtract \n 3.multiply \n 4.divide");
                int choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (choice > 4)
                    {
                        throw new InvalidChoice("invalid choice");
                    }
                }
                catch(InvalidChoice e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (choice)
                {
                    case 1: result = num1 + num2;
                        Console.WriteLine(result);

                        //throw new CorrectInputException("Invalid input enter numbers");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine(result);
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine(result);
                        break;
                    case 4:
                        try
                        {
                            result = num1 / num2;
                            Console.WriteLine(result);
                        }
                        catch(DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
                Console.WriteLine("do u want to continue");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'y');
        }
    }
  
}
