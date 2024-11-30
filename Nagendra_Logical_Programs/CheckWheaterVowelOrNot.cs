using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class CheckWheaterVowelOrNot
    {
        public void m38()
        {
          
            char c = ' ';
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("consonent")
            }

            Console.ReadLine();
        }
    }
}
