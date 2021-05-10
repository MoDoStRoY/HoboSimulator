using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.World.Maps
{
    class City: ILocation
    {
        public String name;

        public City(String name)
        {
            this.name = name;
        }

        public String TestMethod()
        {
            return name;
        }
    }
}
