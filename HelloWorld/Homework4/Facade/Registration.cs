using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Facade
{
    public class Registration
    {
        private IBoat _boat;

        public Registration(IBoat boat)
        {
            this._boat = boat;
        }

        public virtual void AllocateBoatNumber()
        {
            Console.WriteLine("Allocating Boat Number...");
        }
    }
}
