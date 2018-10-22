using System;

namespace Fundamentals
{
    public class Square : Shape
    {
        //properties
        public int Length { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }

        public override int Sides {set;get;}
        public double Radius;
        //Constructor
        public Square(int length, int height)
        {
            if (Length == Height)
            {
                Console.WriteLine("This is a square");
            }
            else
            {
                Console.WriteLine("This is a rectangle");
            }

            this.Length = length;
            this.Height = height;
        }
        public Square() { }
        //method 
        public void Deconstruct(out int length, out int height)
        {
            length = this.Length;
            height = this.Height;
        }
        public override double Area()
        {
            Sides = 4;
            return 45.0;
        }

        public override void MyCoolMethod(){}

    }
}
