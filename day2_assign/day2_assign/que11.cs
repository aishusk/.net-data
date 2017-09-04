using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que11
    {
        public void check_vowel()
        {
            Console.WriteLine("enter a letter");
            char letter = Convert.ToChar(Console.ReadLine());
            if(letter=='a'|| letter == 'e'|| letter == 'i'|| letter == 'o' || letter == 'u')
            {
                Console.WriteLine("it is a vowel");
            }
            else
            {
                Console.WriteLine("it is a consonant");
            }
        }
    }
}
