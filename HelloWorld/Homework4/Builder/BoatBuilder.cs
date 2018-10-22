using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Builder
{
    public abstract class BoatBuilder
    {
        public abstract IBoat Boat { get; }

        public virtual void BuildOutboardEngine() { }

        public virtual void BuildInboardEngine() { }

        public virtual void BuildSteering() { }
    }
}
