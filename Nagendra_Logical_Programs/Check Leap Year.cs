using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Check_Leap_Year
    {
        public void m34()
        {
            Console.WriteLine("entr the year");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n % 4 == 0)
            {
                Console.WriteLine("leap year");

            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}
