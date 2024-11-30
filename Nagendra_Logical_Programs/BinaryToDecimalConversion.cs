using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class BinaryToDecimalConversion
    {
        public void m14()
        {
            Console.Write("Enter a binary number: ");
            string binaryNumber = Console.ReadLine();
            int decimalNumber = ConvertToDecimal(binaryNumber);
            Console.WriteLine("Decimal representation: " + decimalNumber);
        }
        public static int ConvertToDecimal(string binaryNumber)
        {
            int decimalNumber = 0; 
            int baseValue = 1; // 2^0
            for (int i = binaryNumber.Length - 1; i >= 0; i--) 
            { 
                if (binaryNumber[i] == '1')
                { 
                    decimalNumber += baseValue; 
                }
                baseValue *= 2; 
            } 
            return decimalNumber;
        }
    }
}
