using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class SinglePrimeNumber
    {
        int n = 5;
        int f;
        public void m5()
        {
            Console.WriteLine("enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n==0 || n == 1)
            {
                f = 1;
            }
            for(int i = 2;i<=n;i++)
            {
                if (n % i == 0)
                {
                    f = 1;
                    break;
                }
            }
            if (f == 1)
            {
                Console.WriteLine("is prime number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
       
    }
}
