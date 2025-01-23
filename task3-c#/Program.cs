using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_c_


{
    public class hotel

    {
       
            public int roomNumber;//field
            public string roomType;//field
            public double price;//field
            public bool isBooked;//field
            public const string hotelName = "Hotel";//Constant
        





        static int factorialNum(int num) // 5
        {
            int result = 1;   //result =1                   // لتخزين النتائج
            for (int i = 1; i <= num; i++)
            {
                result = result * i; // result = 1*1 =1 // result = 1*2 = 2 /// result = 2* 3 = 6 // result = 6* 4 = 24 // result = 24* 5 = 120

            }


            return result; // final rsult 

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Q1.Insert a number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd");
            }

            Console.WriteLine("Q2.It will display the  2nd smallest of the five {1,7,8,9,0}");
            int[] secound = { 1, 7, 8, 9, 0 };
            Array.Sort(secound); // array.sort  هي build in function بترتب الارقام من الاصغر الى الاكبر 
            //{0,1,7,8,9}
            Console.WriteLine(secound[1]);





            Console.WriteLine("Q3.");
            int number1 = int.Parse(Console.ReadLine()); // 5

            if (number1 < 0) // 5<0
            {

                Console.WriteLine("Factorial is not defined for negative numbers");
            }
            else
            {
                int factorial = factorialNum(number1); //factorialNum(5)
                Console.WriteLine($"The factorial of {number1} is: {factorial}");
            }


            Console.WriteLine("Q4.");
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine()); // إدخال عدد الصفوف

            int number2 = 1; // بدء الأرقام من 1

            // الحلقة الخارجية للصفوف
            for (int row = 1; row <= n; row++)
            {
                // الحلقة الداخلية للأرقام داخل كل صف
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(number2 + " "); // طباعة الرقم
                    number2++; // زيادة الرقم
                }
                Console.WriteLine(); // الانتقال إلى الصف التالي





                Console.WriteLine("Q . last Q");


                hotel Room1 = new hotel();
                Room1.roomNumber = Convert.ToInt32(Console.ReadLine());
                Room1.roomType = Console.ReadLine();
                Room1.price = Convert.ToDouble(Console.ReadLine());
                Room1.isBooked = Convert.ToBoolean(Console.ReadLine());
                //hotel.hotelName = Console.ReadLine();
                Console.WriteLine($"{Room1.roomNumber} {Room1.roomType} {Room1.price} {Room1.isBooked} {hotel.hotelName}");
                //---------------------------------------------
                Console.WriteLine(hotel.hotelName);
                hotel Room2 = new hotel();
                Room2.roomNumber = Convert.ToInt32(Console.ReadLine());
                Room2.roomType = Console.ReadLine();
                Room2.price = Convert.ToDouble(Console.ReadLine());
                Room2.isBooked = Convert.ToBoolean(Console.ReadLine());
                //hotel.hotelName = Console.ReadLine();
                Console.WriteLine(hotel.hotelName);
                Console.WriteLine($"{Room2.roomNumber} {Room2.roomType} {Room2.price} {Room2.isBooked} {hotel.hotelName}");


            }


        }
    }
}
