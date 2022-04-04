using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool RequiresHelmet { get; set; }

        public override void DriveAbstract() //implementing GetType() method
        {
            Console.WriteLine($"I'm riding my {GetType().Name} which is a {GetType().BaseType.Name} in an abstract method."); ;
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I'm riding my virtual motorcycle."); ;
        }
    }
}
