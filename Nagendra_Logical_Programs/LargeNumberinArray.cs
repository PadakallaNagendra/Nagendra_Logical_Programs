using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class LargeNumberinArray
    {
        public void m9()
        {
            int[] num = { 1, 5, 3, 6, 4, 8, 9, 6, 4, 1, 2, 3, 77, 55 };
            int a = num[0];
            for(int i = 1; i < num.Length; i++)
            {
                if (a > num[i])
                {
                    a= num[i];
                }
            }
            Console.WriteLine("smallest number in an array"+" :"+a);
            Console.ReadLine();
        }
    }
}
