using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_c_21_1
{

    using System;


}

class Student
{
    /* Private fields to apply encapsulation */
    private string name; // Field to store the student's name
    private int age;     // Field to store the student's age
    private int studentId; // Field to store the student's ID
    private const int minAge = 18; // Minimum allowed age
    private const int maxAge = 40; // Maximum allowed age

    /* Properties for the constant values (read-only) */
    public int MinAge { get; } // Property to get the minimum age
    public int MaxAge { get; } // Property to get the maximum age

    /* Auto-implemented property for storing email */
    public string Email { get; set; }

    /* Properties to control access to private fields */
    public string Name
    {
        get { return name; } // Getter for the name
        set { name = value; } // Setter for the name
    }
    public int StudentId
    {
        get { return studentId; } // Getter for the student ID
        set { studentId = value; } // Setter for the student ID
    }
    public int Age
    {
        get { return age; } // Getter for the age
        set { age = value; } // Setter for the age
    }

    /* Method to display student details */
    public void GetDetails()
    {
        Console.WriteLine($"Student Details\nName: {name}\nAge: {age}\nID: {studentId}");
    }

    /* Constructor with parameters to initialize the object */
    public Student(string name, int age, int studentId)
    {
        // Validate that the age is within the allowed range
        if (age < minAge)
        {
            Console.WriteLine("Age Should Be More Than 18");
            age = minAge; // Set to minimum age if it's below the limit
        }
        else if (age > maxAge)
        {
            Console.WriteLine("Age Should Be At Maximum 40");
            age = maxAge; // Set to maximum age if it exceeds the limit
        }
        else
        {
            this.age = age; // Assign the valid age
        }
        this.name = name; // Assign the name
        this.studentId = studentId; // Assign the student ID
    }

 

    /* Destructor: called automatically when the object is destroyed */
    ~Student()
    {
        Console.WriteLine($"{name} Left");
    }

    /* Main method to run the program */
    static void Main(string[] args)
    {
        // Create an object using the default constructor
        Student ahmad = new Student("Ahmad",22,200);
       
        ahmad.GetDetails(); // Display the student's details
        Console.WriteLine(" ");

        // Create an object using the parameterized constructor
        Student sara = new Student("Sara", 25, 912);
        sara.GetDetails(); // Display the student's details
        Console.WriteLine(" ");

        // Create an object with age less than the minimum
        Student rafeef = new Student("omar", 13, 1565);
        Console.WriteLine(); // Display a warning and details
    }
}


    //1- A class is a template or blueprint we use it to make the code more organized
    //2- An object is an instance of the class to spacify values to the class properties
    //3- An object is an instance of the class (Part Of It)
    //4- Encapsulation, Abstract, polymorphism and inheritance
    //5- A property is a way to encabsulate the class feild so we can print or modify the feilds without a direct access to it
    //6- A feild is a normal variable declared inside a class.
    //7- A Constructor is a special method to initialize the object feilds and it will be executed automatically when we create an object
    //8- Encapsulation is one of the OOP principles and it means to hide what is supposed to be hidden and only show what is necessery
    