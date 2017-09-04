using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que7
    {
        public void Reverse_sentence()
        {
            Console.WriteLine("enter a sentence");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);
            Array.Reverse(words);
            string reversed_sentence = string.Join(" ", words);
            Console.WriteLine("reversed sentence is= \t"+  reversed_sentence);
        }
       
    }
}
