﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeurons.Lib
{
    public abstract class Output : ParameteredOutput
    {
        public abstract void Invoke();
        public override void Invoke(object[] parameters) => Invoke();
        public override int GetExpectedParameters() => 0;
    }
}
