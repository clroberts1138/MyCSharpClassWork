using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Facade
{
    public class BoatFacade
    {
        public virtual void PrepareForSale(IBoat boat)
        {
            Registration reg = new Registration(boat);
            reg.AllocateBoatNumber();
            Documentation.PrintBrochure(boat);
            boat.CleanBoat();
            boat.LoadTrailer();
            boat.ParkInLot();
        }
    }
}
