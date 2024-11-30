using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class SumOfFirst_N__Natural_Numbers
    {
       // In this C# program, we will take input from the user and
       // generate the sum of first N natural Numbers.
       // The sum of natural numbers up to 10 is: 1+2+3+4+5+6+7+8+9+10=55
        public void m20()
        {
            int i, sum = 0, n;
            Console.Write("Enter the Nth Number : ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of N Numbers : " + sum);
            Console.ReadLine();
        }
    }
}
