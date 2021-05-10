using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Actor
{
    class Parameter
    {
        public String name;
        public int value;

        public Parameter(String name, int value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
