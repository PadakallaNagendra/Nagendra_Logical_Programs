using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class Palindrom
    {
        public void m1()
        {
            int n, t, r = 0;
            Console.WriteLine("enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            t = n;
            while(t > 0)
            {
                r = r * 10;
                r=r+t%10;
                t=t/10;

            }
            if (n == r)
            {
                Console.WriteLine("It is a paindrom");

            }
            else
            {
                Console.WriteLine("not a palindrom");

            }
            Console.ReadLine();
        }
    }
}
