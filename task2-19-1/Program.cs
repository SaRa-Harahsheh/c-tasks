using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace task2_19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1--------
            Console.WriteLine("Q1.plz insert double num ");

            string value = Console.ReadLine();
            //double value = 1.2;
            double result = Convert.ToDouble(value);
            int integer = Convert.ToInt32(result);
            Console.WriteLine(integer);


            //2-------------
            Console.WriteLine("Q2.plz insert number");

            string age = Console.ReadLine();

            string agee = age;
            Console.WriteLine($"Your number is: {agee}");


            //3-------------
            Console.WriteLine("Q3.plz insert text");

            string text = Console.ReadLine();
            Console.WriteLine($"UpperCase: " +text.ToUpper());   
            Console.WriteLine($"lowerCase: " + text.ToLower());


            //4---------------
            Console.WriteLine("Q3.insert your first name & last name");
            string name = Console.ReadLine();
            string fName = name.Substring(0, 5);
            string lName = name.Substring(6);
            Console.WriteLine(fName);
            Console.WriteLine(lName);
            Console.WriteLine(fName.Length + lName.Length);
            Console.WriteLine();

            //5---------------------
            
            Console.WriteLine("Enter Two Numbers:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            int num1 = int.Parse(x);
            int num2 = int.Parse(y);

            if (num1 > num2)
                Console.WriteLine($"{num1} is larger than {num2}");
            else if (num2 > num1)
                Console.WriteLine($"{num2} is larger than {num1}");
            else
                Console.WriteLine("Numbers are equal");
            Console.WriteLine();
        }
    }
}
