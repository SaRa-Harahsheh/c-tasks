using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_c_22_1
{
    class Vehicle
    {

       public string Brand { get; set; }  // auto proprety

       public int Model  { get; set; }

        public  void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
        public void DisplayInformation()
        {
            Console.WriteLine($"Brand: {Brand} , Model: {Model}");
        }
        
    }

    class Car : Vehicle 
    {
        public int NumberOfDoors {  get; set; }
       


    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehical = new Vehicle();


            Car car = new Car();
            car.Brand = "camry";

            car.Model = 2024;
            vehical.Start();
            car.Start();

        }
    }
}
