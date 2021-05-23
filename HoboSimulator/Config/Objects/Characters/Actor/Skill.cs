using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Actor
{
    class Skill
    {
        public String name;
        public int value;

        public Skill(String name, int value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
