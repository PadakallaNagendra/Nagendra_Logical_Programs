using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class SumOFDigits
    {
        // find the out the based on the given numbers but 0 zero is not count
        //ex : give "100" but out put "1" give "111" give out put "3"
        public void m12()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()); 
            int sum = 0; 
            while (num != 0)
            { sum += num % 10;
                num /= 10; 
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
            
    }
}
