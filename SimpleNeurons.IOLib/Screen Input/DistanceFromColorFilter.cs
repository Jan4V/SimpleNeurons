using System;
using System.Drawing;
using SimpleNeurons.Lib;

namespace SimpleNeurons.IOLib
{
    public class DistanceFromColorFilter : Filter
    {
        private readonly int _maxDistance, _resolution;
        private readonly Color _targetColor;

        public DistanceFromColorFilter(int maxDistance, int resolution, Color targetColor)
        {
            _maxDistance = maxDistance;
            _resolution = resolution;
            _targetColor = targetColor;
        }

        public override bool IsMet(object[] parameters)
        {
            if (parameters.Length == 2)
            {
                int centerX = (int) parameters[0], centerY = (int) parameters[1];
                Rectangle searchArea = new Rectangle(Math.Max(0, centerX - _maxDistance),Math.Max(0, centerY - _maxDistance), _maxDistance * 2, _maxDistance * 2);
                for (int x = searchArea.X; x < searchArea.X + searchArea.Width; x += _resolution)
                {
                    for (int y = searchArea.Y; y < searchArea.Y + searchArea.Height; y += _resolution)
                    {
                        if (ScreenInterface.GetColorAt(new Point(x, y)) == _targetColor)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}