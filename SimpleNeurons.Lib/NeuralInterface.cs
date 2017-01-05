using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeurons.Lib
{
    public abstract class NeuralInterface
    {
        public abstract Neuron GetRandomNeuron();
        public abstract void AddNeuron(Neuron neuron);
        public abstract void Think();
    }
}
