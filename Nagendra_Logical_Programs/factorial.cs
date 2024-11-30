using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class factorial
    {
       
        public void m7()
        {
            int n;
            int f = 1;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                f = f * i;
                

            }
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
