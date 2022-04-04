using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year = "2015";
        public string Make = "Honda";
        public string Model = "Civic";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I'm driving!");
        }
    }
}

/*The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             *Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.*/