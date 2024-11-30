using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Calculate_the_Area_of_a_Circle
    {
        public void m24()
        {
            Console.Write("Enter Radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad * rad;
            Console.WriteLine("Area of circle is: " + area);
            Console.ReadLine();
        }
    }
}
