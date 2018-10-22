using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public abstract class AbstractEngine : IEngine
    {
        private int _size;
        private bool _outboard;

        public AbstractEngine(int size, bool outboard)
        {
            this._size = size;
            this._outboard = outboard;
        }

        public virtual int Size
        {
            get
            {
                return _size;
            }
        }

        public virtual bool Outboard
        {
            get
            {
                return _outboard;
            }
        }
        public override string ToString()
        {
            return this.GetType().Name + " with an engine size of " + _size + " cubic inches. ";

        }
    }
}
