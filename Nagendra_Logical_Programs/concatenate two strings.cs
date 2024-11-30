using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class concatenate_two_strings
    {
        public void m37()
        {
            string str1, str2, result;

            Console.Write("Enter first string : ");
            str1 = Console.ReadLine();

            Console.Write("Enter second string : ");
            str2 = Console.ReadLine();

            result = string.Concat(str1, str2);
            Console.Write("Output: " + result);
            Console.ReadLine();
        }
    }
}
