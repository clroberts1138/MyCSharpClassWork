using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class UltraEngine
    {
        private int size;
        
        public UltraEngine(int size)
        {
            this.size = size;
        }

        public virtual int EngineSize
        {
            get { return size; }
        }

        public override string ToString()
        {
            return "ULTRA ENGINE " + size;
        }
    }
}
