using SimpleNeurons.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeurons.IOLib
{
    public class MouseClickOutput : Output
    {
        public override void Invoke()
        {
            Win32.MouseEvent(Win32.MouseEventFlags.LeftDown | Win32.MouseEventFlags.LeftUp);
        }
    }
}
