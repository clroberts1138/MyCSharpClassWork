using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FishingBoatFrame : IBoatFrame
    {
        public virtual string BoatFrameParts
        {
            get { return " Frame Parts for Fishing Boat"; }
        }
    }
}
