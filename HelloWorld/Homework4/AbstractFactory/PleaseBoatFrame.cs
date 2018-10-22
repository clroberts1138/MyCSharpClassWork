using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PleasureBoatFrame : IBoatFrame
    {
        public virtual string BoatFrameParts
        {
            get { return " Frame parts for pleasure boat "; }
        }
    }
}
