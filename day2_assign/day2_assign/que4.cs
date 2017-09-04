using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que4
    {
        public void longest_word()
        {
            Console.WriteLine("enter a sentence");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int string_length = 0;
            foreach (String s in words)
            {
                if (s.Length > string_length)
                {
                    word = s;
                    string_length = s.Length;
                }
            }

            Console.WriteLine(word);

        }
    }
}
