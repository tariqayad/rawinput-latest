using System;

namespace RawInput_dll
{
    public class RawInputEventArg : EventArgs
    {
        public RawInputEventArg(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}
