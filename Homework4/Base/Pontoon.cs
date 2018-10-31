using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Pontoon : AbstractFishingBoat
    {
        public Pontoon(IEngine engine)
            : this(engine, BoatColor.Metallic_Grey)
        {
        }

        public Pontoon(IEngine engine, BoatColor color)
            : base(engine, color)
        {
        }
        public override decimal Price
        {
            get { return 30000.00m; }
        }
    }
}
