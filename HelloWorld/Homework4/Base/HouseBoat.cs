using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class HouseBoat : AbstractPleasureBoat
    {
        public HouseBoat(IEngine engine)
            : this(engine,BoatColor.Sandstone_Brown)
        {
        }

        public HouseBoat(IEngine engine,BoatColor color)
            : base(engine,color)
        {
        }
        public override decimal Price
        {
            get { return 70000.00m; }
        }

    }
}
