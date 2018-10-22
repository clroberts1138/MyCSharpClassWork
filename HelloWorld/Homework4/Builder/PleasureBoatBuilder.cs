using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Builder
{
    public class PleasureBoatBuilder : BoatBuilder
    {
        public AbstractPleasureBoat pleasureBoatInProgress;

        public override IBoat Boat
        {
            get { return pleasureBoatInProgress; }
        }

        public PleasureBoatBuilder(AbstractPleasureBoat pleasureBoat)
        {
            this.pleasureBoatInProgress = pleasureBoat;
        }

        public override void BuildSteering()
        {
            Console.WriteLine("Building Pleasureboat Steering System.");
        }

        public override void BuildInboardEngine()
        {
            Console.WriteLine("Building Pleasureboat Inboard Engine");
        }
        
    }
}
