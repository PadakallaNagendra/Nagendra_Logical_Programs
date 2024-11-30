using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    internal class Find_The_Repeted_Value
    {
        public void m23()
        {
            int count = 0;
            Console.WriteLine("enter the string name");
            string Name= Console.ReadLine();
            for (int i = 0; i <=Name.Length-1; i++)
            {
                for(int j = i + 1; j < Name.Length; j++)
                {
                    if (Name[i] == Name[j])
                    {
                         Console.WriteLine(Name[i]+" repeted value");
                        
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
