using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool RequiresHelmet { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I'm riding the motorcycle!"); ;
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Riding my motorcycle"); ;
        }
    }
}
