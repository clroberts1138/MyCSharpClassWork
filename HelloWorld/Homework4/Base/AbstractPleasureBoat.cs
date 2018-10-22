using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public abstract class AbstractPleasureBoat : AbstractBoat
    {    
        public AbstractPleasureBoat(IEngine engine)
            : this(engine, BoatColor.Sandstone_Brown)
        {
        }

        public AbstractPleasureBoat(IEngine engine,BoatColor color)
            : base(engine, color)
        {
        }
        public override decimal Price
        {
            get { return 30000.00m; }
        }
       
    }
}
