using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Decorator
{
    public abstract class AbstractBoatOption : AbstractBoat
    {
        protected internal IBoat decoratedBoat;

        public AbstractBoatOption(IBoat boat)
            :base(boat.Engine)
        {
            this.decoratedBoat = boat;
        }
    }
}
