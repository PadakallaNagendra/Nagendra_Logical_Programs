using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Recursion
    {
        public void m11(int x, int y)
        {
            Console.WriteLine(x);
            x++;
            if (x <= y)
            {
                m11(x, y);
            }
            Console.ReadLine();
        }
    }
}
