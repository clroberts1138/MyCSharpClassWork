using System;

namespace Homework3
{
    public class DeluxeBike : MultiGearBike
    {
        // Private field declarations
        private string _horn, _headLamp, _tailLamp, _waterBottle, _bikePump, _toolBox;

        // Properties for Class and any additional ones not inherited from Parent Class
        public override int WheelSize { get; } = 29;
        public override int Gears { get; } = 21;

        private string Horn
        {
            set
            {
                this._horn = value;
            }
            get
            {
                Console.WriteLine("Horn Attached!!");
                return _horn;
            }

        }
        private string HeadLamp
        {
            set
            {
                this._headLamp = value;
            }
            get
            {
                Console.WriteLine("Head Lamp Attached!!");
                return _headLamp;
            }
        }

        private string TailLamp
        {
            set
            {
                this._tailLamp = value;
            }
            get
            {
                Console.WriteLine("Tail Lamp Attached!!");
                return _tailLamp;
            }
        }
        private string WaterBottle
        {
            set
            {
                this._waterBottle = value;
            }
            get
            {
                Console.WriteLine("Water Bottle Attached!!");
                return _waterBottle;
            }
        }

        private string BikePump
        {
            set
            {
                this._bikePump = value;
            }
            get
            {
                Console.WriteLine("Bike Pump Installed!!");
                return _bikePump;
            }
        }

        // Example of using Generics to define a Property
        private string ToolBox
        {
            set
            {
                Console.WriteLine("Executing Set for ToolBox");
                this._toolBox = value;
            }
            get
            {
                Console.WriteLine("Executing Get for ToolBox");
                Console.WriteLine("Tool Box Installed!!");
                MyGenericArray<string> toolBox = new MyGenericArray<string>(5);
                toolBox.setItem(0, "Wrench");
                toolBox.setItem(1, "Pliers");
                toolBox.setItem(2, "FlashLight");
                toolBox.setItem(3, "Whistle");
                toolBox.setItem(4, "Compass");
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(toolBox.getItem(c) + " ");
                }
                Console.WriteLine();
                return _toolBox;
            }
        }
        //Constructor for DeluxeBike
        public DeluxeBike()
        {
            Horn = "yes";
            HeadLamp = "yes";
            TailLamp = "yes";
            WaterBottle = "yes";
            BikePump = "yes";
            ToolBox = "yes";
            Console.WriteLine("Deluxe Bike");
            Console.WriteLine("Horn:        " + Horn);
            Console.WriteLine("HeadLamp:    " + HeadLamp);
            Console.WriteLine("TailLamp:    " + TailLamp);
            Console.WriteLine("WaterBottle: " + WaterBottle);
            Console.WriteLine("BikePump:    " + BikePump);
            Console.WriteLine("ToolBox:     " + ToolBox);
            Console.WriteLine("Derailer:    " + Derailer);
        }


        public DeluxeBike(string type) // Constructor with a parameter
        {
            Console.WriteLine(type);
            Horn = "yes";
            HeadLamp = "yes";
            TailLamp = "yes";
            WaterBottle = "yes";
            BikePump = "yes";
            Console.WriteLine("Deluxe Bike");
            Console.WriteLine("Horn:        " + Horn);
            Console.WriteLine("HeadLamp:    " + HeadLamp);
            Console.WriteLine("TailLamp:    " + TailLamp);
            Console.WriteLine("WaterBottle: " + WaterBottle);
            Console.WriteLine("BikePump:    " + BikePump);
            Console.WriteLine("ToolBox:     " + ToolBox);
            Console.WriteLine("Derailer:    " + Derailer);
        }

        // Method Overrides <None in this case>
    }
}
