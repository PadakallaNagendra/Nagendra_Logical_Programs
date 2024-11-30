using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Calculate_the_Area_of_a_Triangle
    {
        public void m26()
        {
            double Base, Height;
            Console.Write("Enter Base of Triangle: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Height of Triangle: ");
            Height = Convert.ToDouble(Console.ReadLine());
            double area = Base * Height / 2;
            Console.WriteLine("Area of Triangle is : {0}", area);
            Console.ReadLine();
        }
    }
}
