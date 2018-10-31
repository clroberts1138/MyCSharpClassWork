using System;

namespace HelloWorld.Week1
{ 
public class Vehicle
{
    /*
        Reference type Field
        Private variables should use an underscore
     */
    private string _color;

    //Normal Property
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

    /*
        Automatic Property
        - Defined as a property with a default private field and 
        default set and get
     */
    public string WheelType { get; set; }

    //Default Constructor
    public Vehicle()
    {
        Console.WriteLine("Default Constructor");
    }

    // Constructor with a parameter
    public Vehicle(string type)
    {
        Console.WriteLine(type);
    }

    // Method with no parameters
    public void OpenDoor()
    {
        Console.WriteLine("Door is Open");
    }

    /*
        Polymorphis Example
        - In order for a child class to override the method, the parent method
        must defined with the virtual keyword
     */
    public virtual void CloseWindow()
    {
        Console.WriteLine("Vehicle Window Closed");
    }
}
}