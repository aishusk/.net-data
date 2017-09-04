using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {
            // CheckNumber();
            //replaceSpace();
            collection1();
           
            Console.ReadLine();
        }
        public static void CheckNumber()
        {
            Console.WriteLine("enter phone number");
            string phno = Console.ReadLine();
           
            string MatchPhoneNumberPattern = @"^\d{3}-\d{4}$";
            Regex r = new Regex(MatchPhoneNumberPattern,RegexOptions.IgnorePatternWhitespace);
            Match m = r.Match(phno);
            if (m.Success)
            {
                Console.WriteLine("Matched number "+phno);
            }
            else
            {
                Console.WriteLine("not matched");
            }

        }
        public static void replaceSpace()
        {
            Console.WriteLine("enter a sentence");
            string sentence = Console.ReadLine();
            string replacement = " ";
            string pattern = "\\s+";
            Regex r = new Regex(pattern);
           string newstr= r.Replace(sentence, replacement);
           
            Console.WriteLine(newstr);
        }
        public static void collection1()
        {
            SortedList mySL = new SortedList();
            mySL.Add(1, "aishu");
            mySL.Add(2, "amara");
            mySL.Add(3, "neel");
            mySL.Add(4, "navin");
            mySL.Add(5, "samu");
            Console.WriteLine("add");
            for (int i = 0; i < mySL.Count; i++)
            {
               
                Console.WriteLine("\t[{0}]:\t{1}\t{2}", i, mySL.GetKey(i), mySL.GetByIndex(i));
            }
            mySL.Remove(2);
            Console.WriteLine("delete");
            for (int i = 0; i < mySL.Count; i++)
            {
                
                Console.WriteLine("\t[{0}]:\t{1}\t{2}", i, mySL.GetKey(i), mySL.GetByIndex(i));
            }
            mySL.SetByIndex(1, "neel");
            Console.WriteLine("update");
            for (int i = 0; i < mySL.Count; i++)
            {
               
                Console.WriteLine("\t[{0}]:\t{1}\t{2}", i, mySL.GetKey(i), mySL.GetByIndex(i));
            }
        }
        
    }
}
