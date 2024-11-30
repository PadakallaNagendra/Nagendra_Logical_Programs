using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class AssendingDesendingOrder
    {
        public void m10()
        {
            int[] num = { 9, 86, 5, 1, 2, 3, 5, 4, 8, 6, 3, 4, 20, 11, 20, 12, 3, 5 };
            int t;
            for(int i = 0; i < num.Length; i++)
            {
                for(int j = i+1;j<num.Length;j++)
                {
                    if (num[i] < num[j])
                    {
                        t = num[i];
                        num[i] = num[j];
                        num[j] = t;
                    }
                }
            }
            for(int i = 0;i < num.Length;i++)
            {
                Console.Write(num[i]);
            }
            Console.ReadLine();
        }
    }
}
