﻿using System;
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
            Console.WriteLine("Q1.plz insert your name:");
            string name =Console.ReadLine();
            Console.WriteLine(name);

            //2-------------
            double myDouble = 2.22;
            string TEXT = "sara";
            char ch = 's';
            bool twoValue = true;
            int integar = 11;
            const int teach = 23;

            Console.WriteLine("dOUBLE VAR: " +" "+ myDouble);
            Console.WriteLine("string"+" " + TEXT);
            Console.WriteLine("charcter"+" "+ ch);
            Console.WriteLine("BOOlean"+" "+ twoValue);
            Console.WriteLine("integar"+ " "+integar);
            Console.WriteLine("constant"+ teach);

            //3------
            string[] cars = { "mrs", "bmw", "odi" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }


            //4----
            Console.WriteLine("Q4.plz insert your first name,last name,your birth");
            string fName = Console.ReadLine() ;
            string lName = Console.ReadLine();
            string birth = Console.ReadLine();

            Console.WriteLine(fName+" "+ lName +" "+ birth);

            //5----
            Console.WriteLine("Q5.plz insert TEN numbers");

            string[] numbers = new string[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers[i]);
            }

        }
    }
}
