using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Calculate_the_Area_of_a_Rectangle
    {
        public void m25()
        {
            double Length, Width;
            Console.Write("Enter Length of Rectangle: ");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width of Rectangle: ");
            Width = Convert.ToDouble(Console.ReadLine());
            double area = Length * Width;
            Console.WriteLine("Area of Rectangle is : {0}", area);
            Console.ReadLine();
        }
    }
}
