using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class vowel
    {
        public void remove_vowel()
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            string[] vowel = str.Split(new[] { 'a', 'e', 'i', 'o', 'u' },StringSplitOptions.None);
           foreach(string data in vowel)
            {
                Console.Write(data);
            }
        }
    }
}
