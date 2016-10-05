using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeurons.Lib
{
    public abstract class NeuralInterface
    {
        public abstract Tuple<Input, ParameteredOutput> GetRandomNeuron();
        public abstract void AddNeuron(Tuple<Input, ParameteredOutput> neuron);
        public abstract void Think();
    }
}
