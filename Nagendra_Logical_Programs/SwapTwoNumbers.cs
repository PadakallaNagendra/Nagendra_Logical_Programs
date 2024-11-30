using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class SwapTwoNumbers
    {
        public void m15()
        {
            Console.WriteLine("enter the a value");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the b value");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a;
            a = b; 
            b = c;
            Console.WriteLine(a+ "a values is");
            Console.WriteLine(b+ "b values is");
            Console.ReadLine();
        }
    }
}
