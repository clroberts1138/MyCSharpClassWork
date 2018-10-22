using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Bass : AbstractBoat
    {
        public Bass(IEngine engine)
            : this(engine, BoatColor.Forrest_Green)
        {
        }

        public Bass(IEngine engine,BoatColor color)
            : base(engine, color)
        {
        }
        public override decimal Price
        {
            get { return 25000.00m; }
        }
    }
}
