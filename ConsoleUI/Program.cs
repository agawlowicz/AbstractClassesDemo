using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles - DONE

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class - DONE
             * Set the properties with object initializer syntax
             */

            var honda = new Car { hasTrunk = true };
            var harley = new Motorcycle { RequiresHelmet = true, Make = "Harley", Model = "Street" };

            Vehicle toyota = new Car { hasTrunk = true, Make = "Toyota", Model = "Camry" };
            Vehicle vespa = new Motorcycle { RequiresHelmet = true, Make = "Vespa", Model = "150" };

            vehicles.Add(honda);
            vehicles.Add(harley);
            vehicles.Add(toyota);
            vehicles.Add(vespa);

            /*
             * Add the 4 vehicles to the list
             * 
             * Using a foreach loop iterate over each of the properties
             */

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
