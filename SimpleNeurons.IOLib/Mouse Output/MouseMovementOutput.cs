using SimpleNeurons.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeurons.IOLib
{
    public class MouseMovementOutput : ParameteredOutput
    {
        public override int GetExpectedParameters() => 2;

        public override void Invoke(object[] parameters)
        {
            int x = Convert.ToInt16(parameters[0]);
            int y = Convert.ToInt16(parameters[1]);
            Win32.SetCursorPosition(x, y);
        }
    }
}
