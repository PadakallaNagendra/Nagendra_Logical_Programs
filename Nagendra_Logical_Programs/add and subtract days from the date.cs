using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class add_and_subtract_days_from_the_date
    {
        public void m33()
        {
            DateTime StartDate = new DateTime(2022, 1, 1);
            DateTime tempDate = StartDate;
            Console.WriteLine("Initial Date : {0}", StartDate);
            Console.WriteLine();

            //--- Add Days to the date
            DateTime ADate = tempDate.AddDays(10);
            Console.WriteLine("Date after adding 10 days to date : {0}", ADate);

            //--- Subtract Days to the date
            tempDate = StartDate;
            DateTime SDate = tempDate.AddDays(-10);
            Console.WriteLine("Date after subtracting 10 days to date : {0}", SDate);

            Console.ReadLine();
        }
    }
}
