using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class print_Star__Triangle
    {
        public void m30()
        {
            int i, j, k, l, n;
            char c = '*';
            Console.Write("Enter the number of rows:");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(c);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(c);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
