using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        public bool hasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I'm driving the car!");
        }
    }
}
