using System;

namespace Homework3
{
    public class MultiGearBike : Bicycle
    {
        // Private field declarations
        private string _derailer;

        // Properties for Class and any additional ones not inherited from Parent Class
        public override int WheelSize { get; } = 27;
        public override int Gears { get; } = 10;
        protected string Derailer { get; } = "Derailer Attached";

        //Constructor for MultiGearBike

        public MultiGearBike()
        {
            Console.WriteLine("MultiGear Bike");
            Console.WriteLine(Derailer);
        }
        public MultiGearBike(string type) // Constructor with a parameter
        {
            Console.WriteLine(type);
            Console.WriteLine(Derailer);
        }

        // Method Overrides 
        public override void Brake()
        {
            Console.WriteLine("Squeezing Brakes on Handlebar!");
        }
    }
}