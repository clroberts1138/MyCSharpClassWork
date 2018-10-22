using System;

namespace HelloWorld.Week1
{ 
public class Car : Vehicle
{

    /*
        Polymorphism Example
        - In order for a child class to override the method, the parent method
        must defined with the virtual keyword, while the child must use the 
        override keyword
    */
    public override void CloseWindow()
    {
        Console.WriteLine("My Car Window is closed");
    }
}
}
