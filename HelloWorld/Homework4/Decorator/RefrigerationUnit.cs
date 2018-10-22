using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Decorator
{
    class RefrigerationUnit : AbstractBoatOption
    {
        public RefrigerationUnit(IBoat boat)
            :base(boat)
        {
        }

        public override decimal Price
        {
            get { return decoratedBoat.Price + 500.00m; }
        }

    }
}
