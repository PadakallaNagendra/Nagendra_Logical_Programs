using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class print_Diamond_Shape
    {
        public void m31()
        {
            int i, j, count = 1, number;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
