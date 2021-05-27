using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.World
{
    class NormalizeParams
    {
        public static int NormalizeIntParam(int value)
        {
            if (value > 100)
                return 100;
            if (value < 0)
                return 0;
            return value;
        }
    }
}
