using System;
using System.Text;

namespace Week3
{
    public partial class Hatchback : Transportation
    {
        public override void Size()
        {
            Console.WriteLine("Hatchback Size");
        }

        public override void Speed()
        {
            Console.WriteLine("Hatchback Speed");
        }

        public override void Weight()
        {
            Console.WriteLine("Hatchback Weight");
        }

        partial void Drive();


    }
}