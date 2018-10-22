using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FishingBoatFactory : AbstractBoatFactory
    {
        public override IBoatFrame CreateBoatFrame()
        {
            return new FishingBoatFrame();
        }

        public override IBoatSeat CreateBoatSeat()
        {
            return new FishingBoatSeat();
        }
    }
}
