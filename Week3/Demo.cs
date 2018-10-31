using System;

namespace Week3
{
    public class Demo : abc,IMyInterface,ITest
    {
        public Demo()
        {
            System.Console.WriteLine("Hello Interfaces I am executing in Demo");
    //       Demo refDemo = new Demo();
    //       System.Console.WriteLine("This will never execute");
    //        refDemo.xyz();
    //        Sample refSample = new Sample();
    //        refSample.xyz();
        }

        public void xyz()
        {
            System.Console.WriteLine("In Demo :: xyz");
        }
        public void MyCoolMethod()
        {
            System.Console.WriteLine("In Demo :: MyCoolMethod");
        }
        public void CalculateArea(int length, int Height)
        {
            System.Console.WriteLine("In Demo :: MyCoolMethod");
        }
        public string TestMethod()  
        {
           return "In Demo :: TestMethod";
        }
        
    }
}