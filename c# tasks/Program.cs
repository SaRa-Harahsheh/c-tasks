using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace c__tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Create console application that read string from user and print the same string

            
            //Console.WriteLine("SARA");
            string name =Console.ReadLine();
            Console.WriteLine(name);

            //2-------------
            double myDouble = 2.22;
            string TEXT = "sara";
            char ch = 's';
            bool s = true;
            int m = 11;
            const int teach = 23;
            Console.WriteLine("dOUBLE VAR: " + myDouble);
            Console.WriteLine("string" + TEXT);


            //3------
            string[] cars = { "mrs", "bmw", "odi" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }


            //4----
            string fName = Console.ReadLine() ;
            string lName = Console.ReadLine();
            string birth = Console.ReadLine();

            Console.WriteLine(fName+" "+ lName +" "+ birth);

            //5----
            string[] numbers = new string[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Console.ReadLine();
            }

        }
    }
}
