using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class ReversString
    {
        public void m8()
        {
            Console.WriteLine("------------");
            string name="Nagendra";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            //char[] aa = name.ToCharArray();
            //Array.Reverse(aa);
            //string a = new string(aa);
            //Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
