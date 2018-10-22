using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Builder
{
    public class PleasureBoatDirector : BoatDirector
    {
        public override IBoat Build(BoatBuilder builder)
        {
            builder.BuildSteering();
            builder.BuildInboardEngine();
            return builder.Boat;
        }
    }
}