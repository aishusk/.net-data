using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class cutomException:Exception
    {
        public cutomException(string message):base(message)
        {

        }

        
    }
    class TestGC
    {
        public void Test()
        {
            int num = 0;
            try
            {
                Console.WriteLine("Enter number greater than 100");
                num = Convert.ToInt32(Console.ReadLine());
                if(num<100)
                {
                    throw new cutomException("exception occured in method Test");
                }
            }
            catch(cutomException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("value{0}",num);
                Test1();
            }
      }


        public void Test1()
        {
            int num = 0;
            try
            {
                Console.WriteLine("Enter negtive number ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    throw new cutomException("exception occured in method Test1");
                }
            }
            catch (cutomException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("value{0}", num);
            }
        }
    }
}
