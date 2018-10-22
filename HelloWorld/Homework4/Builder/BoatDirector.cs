using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Builder
{
    public abstract class BoatDirector
    {
        public abstract IBoat Build(BoatBuilder builder);
    }
}
