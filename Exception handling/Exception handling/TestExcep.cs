using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class TestExcep
    {
        public void castExcep()
        {
            string abc=null;
            
            try
            {
               int i = abc.Length;
                Console.WriteLine("enter char");
                DateTime dt = Convert.ToDateTime(Console.ReadLine());
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("exception example");
            }
        }
    }
}
