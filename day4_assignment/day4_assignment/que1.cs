using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_assignment
{
   static class Extension
    {
        public static string Upper(this string str)
        {
            string input = str;
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }
}
