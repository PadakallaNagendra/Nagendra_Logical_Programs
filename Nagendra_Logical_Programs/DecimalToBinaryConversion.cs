using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class DecimalToBinaryConversion
    {
        public void m13()
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine()); 
            string binary = ConvertToBinary(decimalNumber);
            Console.WriteLine("Binary representation: " + binary);
        }
        static string ConvertToBinary(int decimalNumber)
        {
            string binary = string.Empty;
            while (decimalNumber > 0)
            { 
                int remainder = decimalNumber % 2; 
                binary = remainder + binary; 
                decimalNumber /= 2; 
            }
            return binary;
        }
    }
}
