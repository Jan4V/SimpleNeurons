using System.Drawing;
using SimpleNeurons.Lib;

namespace SimpleNeurons.IOLib
{
    public class ScreenInput : Input
    {
        private readonly int _x, _y;
        protected Color TargetColor;

        public ScreenInput(int x, int y, Color targetColor)
        {
            _x = x;
            _y = y;
            TargetColor = targetColor;
        }

        public override bool IsMet() => ScreenInterface.GetColorAt(new Point(_x, _y)) == TargetColor;

        public override object[] GetOutputParameters() => new object[]{};
    }
}
