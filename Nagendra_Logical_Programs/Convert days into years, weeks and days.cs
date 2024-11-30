using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Convert_days_into_years__weeks_and_days
    {
        public void m36()
        {
            int ndays, year, week, days;
            Console.Write("Enter the number of days: ");
            ndays = int.Parse(Console.ReadLine());
            year = ndays / 365;
            week = (ndays % 365) / 7;
            days = (ndays % 365) % 7;
            Console.WriteLine("{0} days is equal to {1} year, {2} weeks and {3} days",
                               ndays, year, week, days);

            Console.ReadLine();
        }
    }
}
