using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Calculate_the_Area_of_a_Square
    {
        // we will take input (side) from the user and calculate the area of a square.
        //Formula to calculate area of Square is A= (side of square*side of square).
        public void m21()
        {
            Console.Write("Enter Side of Square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double area = side * side;
            Console.WriteLine("Area of square having side {0} is: {1}", side, area);
            Console.ReadLine();
        }
       
    }
}
