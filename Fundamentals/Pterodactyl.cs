using System;

namespace Fundamentals
{
    public class Pterodactyl : Dinosaur
    {
       public override void Eat()
       {
           // something
           Console.WriteLine("Pterodactyl Eat");
       }

       public void Fly()
       {
           // do something
           Console.WriteLine("Fly");
       }
    }
}