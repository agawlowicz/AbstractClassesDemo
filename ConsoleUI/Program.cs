using System;
using System.Collections.Generic; //to use lists
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            var vehicles = new List<Vehicle>(); //list of type Vehicle

            var honda = new Car { hasTrunk = true };
            var harley = new Motorcycle { RequiresHelmet = true, Make = "Harley", Model = "Street" };

            Vehicle toyota = new Car { hasTrunk = true, Make = "Toyota", Model = "Camry" };
            Vehicle vespa = new Motorcycle { RequiresHelmet = true, Make = "Vespa", Model = "150" };

            vehicles.Add(honda);
            vehicles.Add(harley);
            vehicles.Add(toyota);
            vehicles.Add(vespa);

            // fore tab tab code snippet
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year, Make, Model:\n{vehicle.Year}, {vehicle.Make}, {vehicle.Model}\n");
                
            }

            // Call each of the drive methods for one car and one motorcycle - DONE

            honda.DriveAbstract();

            harley.DriveVirtual();

            toyota.DriveVirtual();

            vespa.DriveAbstract();


            #endregion            
            Console.ReadLine();
        }
    }
}
