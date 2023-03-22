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
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constructors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            Car avalanche = new Car() { HasTrunk = true, Make = "Chevrolet", Model = "Avalanche", Year = 2008 };
            Motorcycle shadow = new Motorcycle() { HasSaddleBag = true, Make = "Honda", Model = "Shadow", Year = 2011 };

            Vehicle moped = new Car() { HasTrunk = false, Make = "Honda", Model = "Moped", Year = 2020 };
            Vehicle skateboard = new Car() { HasTrunk = false, Make = "Osiris", Model = "Bob Burnquist", Year = 2004 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(avalanche);
            vehicles.Add(shadow);
            vehicles.Add(moped);
            vehicles.Add(skateboard);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make : {veh.Make} Model : {veh.Model} Year : {veh.Year}");
                veh.DriveAbstract();
                Console.WriteLine("");
            }

            // Call each of the drive methods for one car and one motorcycle

            avalanche.DriveAbstract();
            Console.WriteLine();
            avalanche.DriveVirtual();
            Console.WriteLine();

            shadow.DriveAbstract();
            Console.WriteLine();
            shadow.DriveVirtual();
            Console.WriteLine();

            #endregion            
            Console.ReadLine();
        }
    }
}
