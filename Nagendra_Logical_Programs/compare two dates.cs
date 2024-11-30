using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class compare_two_dates
    {
        public void m35()
        {
            DateTime date1 = new DateTime(2022, 2, 1); //---- Year,Month,Date
            DateTime date2 = new DateTime(2022, 1, 1); //---- Year,Month,Date

            int result = DateTime.Compare(date1, date2);
            if (result > 0)
            {
                Console.WriteLine("date1 {0} is greater than date2 {1}.", date1, date2);
            }
            else if (result < 0)
            {
                Console.WriteLine("date1 {0} is less than date2 {1}.", date1, date2);
            }
            else
            {
                Console.WriteLine("date1 {0} is the same as date2. {1}", date1, date2);
            }

            Console.ReadLine();
        }
    }
}
