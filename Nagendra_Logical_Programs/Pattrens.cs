using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class Pattrens
    {
        int n;
        public void m2()
        {
            Console.WriteLine("enter the lines of pattren number");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
        public void m3()
        {
            Console.WriteLine("enter the lines of pattren number");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;i <= n; i++)
            {
                for(int j = 1;j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
        public void m4()
        {
            Console.WriteLine("enter the lines of number");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >=1; i--)
            {
                for (int j = i; j >=1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }

    }
}
