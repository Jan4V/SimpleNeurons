using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeurons.Lib
{
    public abstract class ParameteredOutput
    {
        public abstract void Invoke(object[] parameters);
        public abstract int GetExpectedParameters();
    }
}
