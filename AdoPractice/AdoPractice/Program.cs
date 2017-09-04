using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s = new Student();
                s.updateData();
                s.getDataSet();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
