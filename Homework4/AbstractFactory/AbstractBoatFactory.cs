using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractBoatFactory
    {
        public abstract IBoatFrame CreateBoatFrame();
        public abstract IBoatSeat CreateBoatSeat();
    }
}
