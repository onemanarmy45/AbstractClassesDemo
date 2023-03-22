using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "No Make";
        public string Model { get; set; } = "No Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"We are virtually driving {GetType().Name}");
        }
    }
}