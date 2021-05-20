using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.World.Maps
{
    interface ILocation
    {
        public String GetName();
        public int GetID();
        public List<IZone> GetListOfZones();
    }
}
