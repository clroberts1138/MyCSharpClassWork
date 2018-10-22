using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PleasureBoatFactory : AbstractBoatFactory
    {
        public override IBoatFrame CreateBoatFrame()
        {
            return new PleasureBoatFrame();
        }

        public override IBoatSeat CreateBoatSeat()
        {
            return new PleasureBoatSeat();
        }
    }
}
