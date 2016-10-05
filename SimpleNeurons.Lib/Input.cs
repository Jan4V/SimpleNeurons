using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeurons.Lib
{
    public abstract class Input
    {
        public abstract bool IsMet();
        public abstract object[] GetOutputParameters();
    }
}
