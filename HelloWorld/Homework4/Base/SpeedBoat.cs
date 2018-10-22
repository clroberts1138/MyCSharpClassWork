using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class SpeedBoat : AbstractPleasureBoat 
    {
        public SpeedBoat(IEngine engine)
            : this(engine, BoatColor.Sparkling_Red)
        {
        }

        public SpeedBoat(IEngine engine, BoatColor color)
            : base(engine, color)
        {
        }
        public override decimal Price
        {
            get { return 35000.00m; }
        }
    }
}
