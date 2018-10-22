using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public abstract class AbstractFishingBoat : AbstractBoat
    {
        public AbstractFishingBoat(IEngine engine)
            :this(engine,BoatColor.Metallic_Grey)
        {
        }

        public AbstractFishingBoat(IEngine engine,BoatColor color)
            : base(engine, color)
        {
        }
        public override decimal Price
        {
            get { return 20000.00m; }
        }
    }
}
