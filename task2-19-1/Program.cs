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

        static double miles (double kilometer)
        {

            return kilometer * 0.621371;

        }

        static int TotalMinutes(int hours, int minutes)
        {
           
            int minutesToHours = hours * 60;

           
            int totalMinutes = minutesToHours + minutes;

           
            return totalMinutes;
        }


        static void TotalHours( int minutes)
        {

            int minutesToHours = minutes / 60;
            int minute = minutes % 60;

            Console.WriteLine(minutesToHours + "hours, " +minute+" mints");


        
        }
        static void smallerNumber(int num1,int num2)
        {
            if (num1 < num2)
            {
                Console.WriteLine(num1);
            }
            else {
               Console.WriteLine( num2);

}        }

        static int sumOfDigits()
        {
            int Sum = 0;
           string x=  Console.ReadLine();

            for (int i = 0; i < x.Length; i++)
            {
                Sum += (char)x[i];
                
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Q6. ");
            //Console.WriteLine(miles(15)+"m/h");


            //Console.WriteLine("Q7. ");
            //int hours = 5; 
            //int minutes = 37;

            //Console.WriteLine(TotalMinutes(hours, minutes));

            //Console.WriteLine("Q8. ");
            //int min = Convert.ToInt32(Console.ReadLine());
            //TotalHours(min);
            //Console.WriteLine("Q9. ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //smallerNumber(n1, n2);

            //Console.WriteLine("Q10. ");

            Console.WriteLine(sumOfDigits()); ;
            ////1--------
            //Console.WriteLine("Q1.plz insert double num ");

            //string value = Console.ReadLine();
            ////double value = 1.2;
            //double result = Convert.ToDouble(value);
            //int integer = Convert.ToInt32(result);
            //Console.WriteLine(integer);


            ////2-------------
            //Console.WriteLine("Q2.plz insert number");

            //int number = Convert.ToInt32(Console.ReadLine());
            // string age = Convert.ToString(number); 
            //Console.WriteLine("Your number is:"+ age);


            ////3-------------
            //Console.WriteLine("Q3.plz insert text");

            //string text = Console.ReadLine();
            //Console.WriteLine("UpperCase: " +text.ToUpper());   
            //Console.WriteLine("lowerCase: " + text.ToLower());




            ////4---------------
            //Console.WriteLine("Q3.insert your first name & last name");
            //string name = "sara Harahsheh";
            //string fName = name.Substring(0, 4);
            //string lName = name.Substring(5);
            //Console.WriteLine(fName);
            //Console.WriteLine(lName);
            //Console.WriteLine(fName.Length + lName.Length);
            //Console.WriteLine();

            ////Console.WriteLine("Q3.insert your first name & last name");
            ////string name = "sara Harahsheh";
            ////string fName = name.Substring(0, name.IndexOf(" "));
            ////string lName = name.Substring(name.IndexOf(" ")+1);
            ////Console.WriteLine(fName);
            ////Console.WriteLine(lName);
            ////Console.WriteLine(fName.Length + lName.Length);
            ////Console.WriteLine();



            ////5---------------------

            //Console.WriteLine("Enter Two Numbers:");
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();

            //int num1 = int.Parse(x);
            //int num2 = int.Parse(y);

            //if (num1 > num2)
            //    Console.WriteLine($"{num1} is larger than {num2}");
            //else if (num2 > num1)
            //    Console.WriteLine($"{num2} is larger than {num1}");
            //else
            //    Console.WriteLine("Numbers are equal");

            ////
            //int num11= Convert.ToInt32(Console.ReadLine());








        }
    }
}
