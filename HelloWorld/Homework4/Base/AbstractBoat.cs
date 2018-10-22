using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public abstract class AbstractBoat : IBoat
    {
        private IEngine _engine;
        private BoatColor _color;

        public virtual IEngine Engine
        {
            get
            {
                return _engine;
            }
        }
        public abstract decimal Price { get; }

        public AbstractBoat(IEngine engine)
            : this(engine, BoatColor.Forrest_Green)
        {
        }

        public AbstractBoat(IEngine engine, BoatColor color)
        {
            this._engine = engine;
            this._color = color;
        }

        public BoatColor ColorType
        {
            get
            {
                return _color;
            }
        }
        public virtual void Paint(BoatColor color)
        {
            this._color = color;
        }

        public virtual void CleanBoat()
        {
            Console.WriteLine("Cleaning Boat");
        }

        public virtual void LoadTrailer()
        {
            Console.WriteLine("Loading Boat on Trailer");
        }

        public virtual void ParkInLot()
        {
            Console.WriteLine("Parking Boat in Sell Lot");
        }

        public override string ToString()
        {
            return this.GetType().Name + " Boat has a " + _engine +
                " and the Color is " + _color + " and it costs $ " + Price;
        }
    }
}
