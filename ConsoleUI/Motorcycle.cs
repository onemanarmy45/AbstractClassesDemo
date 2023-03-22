using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

        public bool HasSaddleBag { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is in drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"We are virtually driving in a {GetType().Name}");
        }
    }
}

