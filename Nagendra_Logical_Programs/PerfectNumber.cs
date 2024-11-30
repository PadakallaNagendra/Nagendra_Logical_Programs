using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
//    This program prompts the user to enter a number and then checks 
//    if it is a perfect number.A perfect number is a positive integer 
//    that is equal to the sum of its proper divisors(excluding the number itself).
//   If the sum of the divisors equals the original number, 
//   it is considered a perfect number.For example, 6 is a perfect number 
//       because its divisors (1, 2, and 3) sum to 6.
//If you have any questions or need more examples, feel free to ask!
    public class PerfectNumber
    {
        public void m19()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }


            if (sum == number && number != 0)
            {
                Console.WriteLine($"{number} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number.");
            }
        }

    }
}
