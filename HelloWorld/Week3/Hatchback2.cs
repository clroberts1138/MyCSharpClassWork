
using System;

namespace Week3
{
    public partial class Hatchback : Transportation
    {
        public void Color()
        {
            Console.WriteLine("Hatchback Color");
        }



        partial void Drive()
        {
            Console.WriteLine("Hatchback also stops");
        }
    }
}