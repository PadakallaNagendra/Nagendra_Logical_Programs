using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class change_case_of_a_string
    {
        public void m32()
        {
            string str;
            Console.Write("Enter string: ");
            str = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The string in upper case: {0}", str.ToUpper());
            Console.WriteLine("The string in lower case: {0}", str.ToLower());

            //---- Convert to Title case
            //---- Add namespace using System.Globalization;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine("The string in title case: {0}", textInfo.ToTitleCase(str));

            Console.ReadLine();
        }
    }
}
