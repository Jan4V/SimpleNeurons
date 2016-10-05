using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeurons.Lib
{
    public abstract class Output : ParameteredOutput
    {
        public abstract void Invoke();
        public override int GetExpectedParameters() { return 0; }
    }
}
