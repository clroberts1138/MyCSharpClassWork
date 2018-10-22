using System;

namespace Homework3
{
    public class Bicycle
    {
        // Private variables should use an underscore
        private string _color, _seat;
        private int _gears = 1;

        //Normal Property

        public string Seat
        {
            set
            {
                this._seat = value;
            }
            get
            {
                return _seat;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                Console.WriteLine(value);
                this._color = value;
            }
        }

        //Automatic Property with only get (to prevent modification of wheelsize for Bike Class)
        public virtual int WheelSize { get; } = 20;

        //Default Constructor  remember Constructors do not have a return type and are called the same name as the Class.
        public Bicycle()
        {
            Console.WriteLine("Default Constructor Bicycle");
        }

        public Bicycle(string type) // Constructor with a parameter
        {
            Console.WriteLine(type);
        }
        public void Pedal()   //Method with no parameters
        {
            Console.WriteLine("Pedaling.");
        }
        public void HandleBar()   //Method with no parameters
        {
            Console.WriteLine("Steering");
        }
        public virtual void Brake() // Example of Polymorphisms
        {
            Console.WriteLine("Coaster Brake!");
        }

        public virtual int Gears
        {
            get
            {
                return _gears;
            }
        }
    }
}