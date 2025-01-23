using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace task2_19_1
{
    internal class Program
    {

        static double miles(double kilometer) // Q.6  we want to convert k/h to m/h 
        {

            return kilometer * 0.621371;

        }

        static int TotalMinutes(int hours, int minutes) //Q.7 we want to convert h/m to m
        {

            int minutesToHours = hours * 60; // convert to minuts


            int totalMinutes = minutesToHours + minutes; // tatal 


            return totalMinutes;
        }


        static void TotalHours(int minutes) // Q8. we want to convert m to h/m 
        {

            int minutesToHours = minutes / 60; // convert m to h 
            int minute = minutes % 60;  // المتبقي من الدقائق المدخله يمثل عدد الدقائق 

            Console.WriteLine(minutesToHours + "hours, " + minute + " mints");



        }
        static void smallerNumber(int num1, int num2)  ///Q9.نطلع الرقم الاصغر  
        {
            if (num1 < num2)
            {
                Console.WriteLine(num1);
            }
            else {
                Console.WriteLine(num2);

            } }

        static int sumOfDigits()  //Q.10 sum of digits 123 --> 1+2+3=6
        {
            int Sum = 0;
            string x = Console.ReadLine();  // "oji" //  char o j i  char 'o'  char 'j'   char 'i'  string ""   //123

            for (int i = 0; i < x.Length; i++)
            {
                string convertTostring = x[i].ToString();  // تحويل كل حرف في الكلمه الى سترنق 
                int convertToInt = Convert.ToInt32(convertTostring);
                Sum += convertToInt;

            }
            return Sum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Q6. ");
            Console.WriteLine(miles(15) + "m/h");




            Console.WriteLine("Q7. ");
            int hours = 5;
            int minutes = 37;

            Console.WriteLine(TotalMinutes(hours, minutes));



            Console.WriteLine("Q8. ");
            int min = Convert.ToInt32(Console.ReadLine());
            TotalHours(min);


            Console.WriteLine("Q9. ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            smallerNumber(n1, n2);




            Console.WriteLine("Q10.OKTBE 3 2RQAM JANB BA3ED ");

            Console.WriteLine(sumOfDigits()); ;




            Console.WriteLine("Q11. ");

            string number = "1234";
            string new_num = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                new_num += number[i];
            }
            //Console.WriteLine(new_num);
            foreach (char i in new_num)
            {
                Console.Write(i);
            }


            //1--------
            Console.WriteLine("Q1.plz insert double num ");   // يدخل المدخل "as string " ونرجعها  double  ثم  int 

            string value = Console.ReadLine();
            //double value = 1.2;
            double result = Convert.ToDouble(value);
            int integer = Convert.ToInt32(result);
            Console.WriteLine(integer);


            //2-------------
            Console.WriteLine("Q2.plz insert number"); //user input as string thin we convert to int thin convert to string l2no als2oal hek bedo

            int number1 = Convert.ToInt32(Console.ReadLine());
            string age = Convert.ToString(number1);
            Console.WriteLine("Your number is:" + age);


            //3-------------
            Console.WriteLine("Q3.plz insert text"); // فقط طالب ندخل نص ويحوله لل upper && lower

            string text = Console.ReadLine();
            Console.WriteLine("UpperCase: " + text.ToUpper());
            Console.WriteLine("lowerCase: " + text.ToLower());




            //4---------------
            Console.WriteLine("Q3.insert your first name & last name");  // insert first name and last name use substring and wiil print the lingth
            string name = "sara Harahsheh";
            string fName = name.Substring(0, 4);
            string lName = name.Substring(5);
            Console.WriteLine(fName);
            Console.WriteLine(lName);
            Console.WriteLine(fName.Length + lName.Length);
            Console.WriteLine();

            //Console.WriteLine("Q3.insert your first name & last name");
            //string name1 = "sara Harahsheh";
            //string fName1 = name.Substring(0, name1.IndexOf(" "));
            //string lName1 = name.Substring(name1.IndexOf(" ") + 1);
            //Console.WriteLine(fName1);
            //Console.WriteLine(lName1);
            //Console.WriteLine(fName1.Length + lName1.Length);
            //Console.WriteLine();



            //5---------------------

            Console.WriteLine("Enter Two Numbers:"); // da5le raqmeeeen ra7 ytla3 al2kbar 
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

            //






        }
    } }

