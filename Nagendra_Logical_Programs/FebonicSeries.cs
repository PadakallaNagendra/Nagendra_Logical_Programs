using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class FebonicSeries
    {
        int n;
       public void m6()
        {
            //Console.WriteLine("enter the number");
            //n=Convert.ToInt32(Console.ReadLine());
            //int t1 = 0;
            //int t2 = 1;
            //Console.Write("\t"+t1);
            //Console.Write("\t"+t2);
            //int t3;
            //for(int i = 3; i <= n; i++)
            //{
            //    t3 = t1 + t2;
            //    Console.Write("\t"+t3);
            //    t1 = t2;
            //    t2= t3;
            //}

            //OR

            int n = 10; int a = 0, b = 1, c;
            Console.Write("Fibonacci Series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " "); 
                c = a + b; 
                a = b; 
                b = c;
            }
                Console.ReadLine();
        }
    }
}
