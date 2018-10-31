using System;

public class Bicycle 
{
//Reference type field
// Private variables should use an underscore
    private string _color;
    private int _sprocket = 20;

//Normal Property
    public string Color 
    {
        get {
            return _color;
        }
        set {
            Console.WriteLine(value);
            this._color = value;
        }
    }

    //Automatic Property
    public string Wheeltype { get; set;}
    //Default Constructor
    public Bicycle()  
    {  
        Console.WriteLine("Default Constructor");
    }

    public Bicycle(string type) // Constructor with a parameter
    {
        Console.WriteLine(type);
    }
    public void Pedal()   //Method with no parameters
    {
        Console.WriteLine("Pedaling");
    }
    public void HandleBar()   //Method with no parameters
    {
        Console.WriteLine("Steering");
    }
    public virtual void Brake() // Example of Polymorphisms
    {
        Console.WriteLine("Squeezing Brake!");
    }

    public virtual int Sprocket
        {
            get
            {
                return _sprocket;
            }
        }
}

