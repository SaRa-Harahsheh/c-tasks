using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_c__23_1_2025
{
    class Calculator
    {
        // overloading
        public void Calc(int num1, int num2) {

            Console.WriteLine($"The multiply of two integar number {num1}*{num2} = " + num1 * num2);

        }

        public void Calc(int num1, int num2, int num3)
        {
            Console.WriteLine($"The multiply of three integar number {num1}*{num2}*{num3} = " + num1 * num2);
        }


        public void Calc(double num1, double num2)
        {
            Console.WriteLine($"The multiply of two double number {num1}*{num2} = " + num1 * num2);
        }

    }




    //overriding
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape.");
        }

    }

    class Circle :Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }


    class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }



    // Abstraction 
    abstract class Animal
    {

        public abstract void makeSound();  // the method abstract without body

        public void sleep()
        {
            Console.WriteLine("Animal is sleeping.");


        }
    }

    class Dog :Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog barks.");
        }


    }

    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Overloading
            Console.WriteLine("<<  Q1_ Overloadin  >>");
            Console.WriteLine("");

            Calculator Multiply = new Calculator();
            Multiply.Calc(2, 3);
            Multiply.Calc(3, 3, 3);
            Multiply.Calc(2.2,2.2);

            Console.WriteLine("--------------------------------");



            //overriding
            Console.WriteLine("<<  Q2_ Overriding  >>");
            Console.WriteLine("");

            Shape shap1= new Shape();
            shap1.Draw();    // Output: Drawing a Shape.

            Shape shap2= new Circle();
            shap2.Draw();    // Output: Drawing a Circle.

            Shape shap3= new Rectangle();
            shap3.Draw();  // Output : Drawing a Rectangle

            Console.WriteLine("--------------------------------");

            //Abstraction
            Console.WriteLine("<<  Q3_ Abstraction  >>");
            Console.WriteLine("");

            Animal animal = new Dog();
            animal.sleep(); 

            Dog dog = new Dog();
            dog.makeSound();

            Cat cat = new Cat();
            cat.makeSound();

            Console.WriteLine("--------------------------------");
        }
    }
}