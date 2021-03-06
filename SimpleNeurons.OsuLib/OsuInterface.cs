﻿using System;
using System.Collections.Generic;
using System.Drawing;
using SimpleNeurons.Lib;
using SimpleNeurons.IOLib;

namespace SimpleNeurons.OsuLib
{
    class OsuInterface : NeuralInterface
    {
        private List<Neuron> _neurons;
        private readonly Random _rand;

        public OsuInterface()
        {
            _neurons = new List<Neuron>();
            _rand = new Random();
        }

        public override void AddNeuron(Neuron neuron) => _neurons.Add(neuron);

        public override Neuron GetRandomNeuron() => new Neuron(GetRandomInput(), GetRandomOutput());

        public override void Think() => _neurons.ForEach(neuron => neuron.Evaluate());

        private Input GetRandomInput()
        {
            switch (_rand.Next(4))
            {
                case 0:
                    return new ScreenSearchInput(Color.FromArgb(255, 255, 0, 0), new DistanceFromColorFilter(_rand.Next(10, 80), 2, Color.FromArgb(255, 0, 255, 0)), new Rectangle(240, 0, 1440, 1080), 2);
                case 1:
                    return new ScreenSearchInput(Color.FromArgb(255, 0, 0, 255), new DistanceFromColorFilter(_rand.Next(10, 40), 2, Color.FromArgb(255, 255, 255, 0)), new Rectangle(240, 0, 1440, 1080), 2);
                case 2:
                    return new ScreenSearchInput(Color.FromArgb(255, 255, 0, 255), new DistanceFromColorFilter(_rand.Next(10, 40), 2, Color.FromArgb(255, 255, 255, 0)), new Rectangle(240, 0, 1440, 1080), 2);
                default:
                    return new ScreenInput(128, 128, Color.FromArgb(255, 255, 255, 255));
            }
        }

        private ParameteredOutput GetRandomOutput()
        {
            switch (_rand.Next(2))
            {
                case 0:
                    return new MouseMovementOutput();
                default:
                    return new MouseClickOutput();
            }
        }
    }
}