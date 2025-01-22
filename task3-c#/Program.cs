using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_c_
{
    public class hotel
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Q1.Insert a number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is odd");
            }
            else { 
                Console.WriteLine($"The number {number} is even");
            }

            Console.WriteLine("Q2.");
            int[] secound = {1,7,8,9,0};
            Array.Sort(secound); // array.sort  هي build in function بترتب الارقام من الاصغر الى الاكبر 
            //{0,1,7,8,9}
            Console.WriteLine(secound[1]);






        }
    }
}