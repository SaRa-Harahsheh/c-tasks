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
    
        public hotel(int roomNumber, string roomType, double price, bool isBooked)
        {
            roomNum = roomNumber;
            roomT = roomType;
            pric = price;
            Booked = isBooked;
        
        
        }

    static void Main(string[] args)
        {
            hotel home = new hotel(12,"in sea",200.2,false);
            Console.WriteLine(home.roomNum+" "+ home.roomT+" "+home.pric+" "+home.Booked);

            //hotel Room1 = new hotel();
            //Room1.roomNumber = Convert.ToInt32(Console.ReadLine());
            //Room1.roomType = Console.ReadLine();
            //Room1.price = Convert.ToDouble(Console.ReadLine());
            //Room1.isBooked = Convert.ToBoolean(Console.ReadLine());
            ////hotel.hotelName = Console.ReadLine();
            //Console.WriteLine($"{Room1.roomNumber} {Room1.roomType} {Room1.price} {Room1.isBooked} {hotel.hotelName}");
            ////---------------------------------------------
            //Console.WriteLine(hotel.hotelName);
            //hotel Room2 = new hotel();
            //Room2.roomNumber = Convert.ToInt32(Console.ReadLine());
            //Room2.roomType = Console.ReadLine();
            //Room2.price = Convert.ToDouble(Console.ReadLine());
            //Room2.isBooked = Convert.ToBoolean(Console.ReadLine());
            ////hotel.hotelName = Console.ReadLine();
            //Console.WriteLine(hotel.hotelName);
            //Console.WriteLine($"{Room2.roomNumber} {Room2.roomType} {Room2.price} {Room2.isBooked} {hotel.hotelName}");
        }






    } }
