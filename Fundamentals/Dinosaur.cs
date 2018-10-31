using System;

namespace Fundamentals
{
    public class Dinosaur
    {
        //Private 
        private string _teeth;
        private string _something;
        private int _size;

        public string Color { set; get; } = "Green";

        public int Size 
        { 
            set
            {
               this._size = value;
            }
             get 
             {
                if(_size > 200)
                {
                    Console.WriteLine("You are huge");
                }
                return _size;
             } 
        }

        public bool Skin { set; get; }

        public string Teeth
        {
            set
            {
                this._teeth = value;
            }

            get
            {
                return _teeth;
            }
        }
        //Methods
        public virtual void Eat()
        {
            Console.WriteLine("DinoSaur Eat");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
        //Inner Class
        public class Raptor : Dinosaur
        {
            public void Group()
            {
                Color = "Brown";
            }
        }


    }

    public class TRex : Dinosaur
    {
        public void Stomp()
        {
            Color = "Blue";
            Console.WriteLine("Stomp");
        }

        public sealed override void Eat()
        {
            Console.WriteLine("Trex Eat");
        }
    }
}