using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Builder
{
    public class FishingBoatBuilder : BoatBuilder
    {
        private AbstractFishingBoat fishingBoatInProgress;

        public override IBoat Boat
        {
            get { return fishingBoatInProgress; }
        }

        public FishingBoatBuilder(AbstractFishingBoat fishingBoat)
        {
            this.fishingBoatInProgress = fishingBoat;
        }

        public override void BuildSteering()
        {
            Console.WriteLine("Building Fishingboat Steering System");
        }

        public override void BuildOutboardEngine()
        {
            Console.WriteLine("Building Fishingboat Outboard Engine");
        }
    }
}
