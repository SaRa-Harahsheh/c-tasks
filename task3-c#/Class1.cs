using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_c_
{
    internal class Class1
    {
        public static void jana()
        {
            int x = 25;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
                else
                {

                    Console.WriteLine("prime");
                    break;

                }
            }
        }
    }
}
