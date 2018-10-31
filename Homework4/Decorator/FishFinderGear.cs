using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Decorator
{
    public class FishFinderGear : AbstractBoatOption
    {
        public FishFinderGear(IBoat boat)
            :base(boat)
        {
        }

        public override decimal Price
        {
            get { return decoratedBoat.Price + 600.00m; }
        }
    }
}
