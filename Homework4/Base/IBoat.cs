using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public interface IBoat
    {
        IEngine Engine { get; }
        BoatColor ColorType { get; }
        decimal Price { get; }

        void Paint(BoatColor color);

        void CleanBoat();
        void LoadTrailer();
        void ParkInLot();
    }
}
