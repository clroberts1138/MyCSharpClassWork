using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework4;

namespace Adapter
{
    public class UltraEngineAdapter : AbstractEngine
    {
        public UltraEngineAdapter(UltraEngine ultraengine)
            :base(ultraengine.EngineSize, false)
        {

        }
    }
}
