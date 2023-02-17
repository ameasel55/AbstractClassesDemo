using System;
namespace ConsoleUI
{
	internal class Motorcycle : Vehicle
	{
        public bool HasBlueTooth { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle Virtual Drive Method");
        }
    }
}

