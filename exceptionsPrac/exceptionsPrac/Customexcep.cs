using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionsPrac
{
    class Customexcep:Exception
    {
        public Customexcep(string message):base(message)
        {

        }
        
    }
    class Temperature
    {
        int temp1=0;
        public void temp(int temp1)
        {
            if(temp1==0)
            {
                throw new Customexcep("temp is zero");
            }
        }

        }
}
