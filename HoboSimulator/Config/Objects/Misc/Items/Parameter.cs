using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Actor
{
    public class Parameter
    {
        public String name;
        public double value;

        public Parameter(String name, double value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
