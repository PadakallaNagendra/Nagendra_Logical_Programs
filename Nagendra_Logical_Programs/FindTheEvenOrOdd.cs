using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class FindTheEvenOrOdd
    {
        public void m18()
        {
            Console.WriteLine("enter the Number");
            int n=Convert.ToInt32(Console.ReadLine());
           
                if (n % 2 == 0)
                {
                    Console.WriteLine(n+" n is even");
                }
                else
                {
                    Console.WriteLine(n+"n Is a Odd");
                }
            
            Console.ReadLine();
        }
    }
}
