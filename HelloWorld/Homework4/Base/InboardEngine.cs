using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class InboardEngine : AbstractEngine
    {
        public InboardEngine(int size) : base(size, false)
        {
            // Not an outboard engine
        }
    }
}
