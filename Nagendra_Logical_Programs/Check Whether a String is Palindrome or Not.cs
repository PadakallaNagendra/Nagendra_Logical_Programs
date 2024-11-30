using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Check_Whether_a_String_is_Palindrome_or_Not
    {
        public void m27()
        {
            //string str, revstr = "";
            //Console.Write("Enter string: ");
            //str = Console.ReadLine();
            //for (int i = str.Length - 1; i >= 0; i--) //String Reverse 
            //{
            //    revstr += str[i].ToString();
            //}
            //if (revstr.ToLower() == str.ToLower()) // Checking whether string is palindrome or not 
            //{
            //    Console.Write("Entered string {0} is a Palindrome string. ", str);
            //}
            //else
            //{
            //    Console.Write("Entered string {0} is not a Palindrome string. ", str);
            //}


            //or


            Console.WriteLine("enter the string name");
            string name = Console.ReadLine();
           
            char[] b=name.ToCharArray();
            Array.Reverse(b);
            string c=new string(b);
            if (c.Equals(name))
            {
                Console.WriteLine("palindrom");
            }
            Console.ReadLine();
        }

    }
}
