using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2015";  //fixed, changed fields to properties, prop code snippet

        public string Make { get; set; } = "Honda";

        public string Model { get; set; } = "Civic";

        public abstract void DriveAbstract(); //derived class must implement this stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I'm driving my virtual vehicle.");
        }
    }
}
