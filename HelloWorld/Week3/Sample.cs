using System;

namespace Week3
{
    public class Sample : abc
    {
        public Sample()
        {
            System.Console.WriteLine("Hello Interfaces I am executing in Sample");
     //       Demo refDemo = new Demo();
     //       refDemo.xyz();
     //       Sample refSample = new Sample();
     //       refSample.xyz();
        }
        public void xyz()
        {
            System.Console.WriteLine("In Sample :: xyz");
        }
        public void MyCoolMethod()
        {
            System.Console.WriteLine("In Sample :: MyCoolMethod");
        }
        public void CalculateArea(int length, int Height)
        {
            System.Console.WriteLine("In Sample :: CalculateArea");
        }
    }
}