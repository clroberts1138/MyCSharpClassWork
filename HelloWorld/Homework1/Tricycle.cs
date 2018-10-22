using System;

namespace HelloWorld.Homework1
{
public class Tricycle : Bicycle   //Inheritence
   {

    public override void Brake()
    {
        Console.WriteLine("Feet are down!");
    }   

    public override int Sprocket { get; } = 35;
   }
}

