using System.Drawing;
using SimpleNeurons.Lib;

namespace SimpleNeurons.IOLib
{
    public class ScreenSearchInput : ScreenInput
    {
        private readonly Filter _filter = null;
        private Rectangle _searchArea;
        private readonly int _resolution;
        private int _lastX=-1, _lastY=-1;
        public ScreenSearchInput(Color targetColor, Filter filter, Rectangle searchArea,int resolution) : base(0, 0, targetColor)
        {
            _filter = filter;
            _searchArea = searchArea;
            _resolution = resolution;
        }

        public override bool IsMet()
        {
            for (int x = _searchArea.X; x < _searchArea.X + _searchArea.Width; x+=_resolution)
            {
                for (int y = _searchArea.Y; y < _searchArea.Y + _searchArea.Width; y+=_resolution)
                {
                    if (ScreenInterface.GetColorAt(new Point(x, y)) == TargetColor &&
                        (_filter == null || (_filter != null && _filter.IsMet(new object[] {x, y}))))
                    {
                        _lastX = x;
                        _lastY = y;
                        return true;
                    }
                }
            }
            return false;
        }

        public override object[] GetOutputParameters()
        {
            if(_lastX != -1 && _lastY != -1)
                return new object[] {_lastX,_lastY};
            return null;
        }
    }
}
