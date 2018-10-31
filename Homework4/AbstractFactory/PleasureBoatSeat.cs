using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PleasureBoatSeat : IBoatSeat
    {
        public virtual string BoatSeatParts
        {
            get { return "Seat parts for Pleasure Boat"; }
        }
    }
}
