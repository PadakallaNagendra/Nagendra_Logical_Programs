using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class multipicationTable
    {
        public void m16()
        {
            Console.Write("Enter a number: "); 
            int num = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"Multiplication Table for {num}:");
            for (int i = 1; i <= 10; i++)
            { 
                Console.WriteLine($"{num} x {i} = {num * i}"); 
            }
        }
    }
}
