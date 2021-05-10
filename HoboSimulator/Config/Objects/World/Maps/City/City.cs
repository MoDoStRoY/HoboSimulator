using HoboSimulator.Config.Objects.World.Maps.City.Zones;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.World.Maps.City
{
    class City : ILocation
    {
        public String name = "Город";
        public List<IZone> listOfZones = new List<IZone>
        {
            new Disctricts()
        };

        public String GetName()
        {
            return name;
        }

        public List<IZone> GetListOfZones()
        {
            return listOfZones;
        }
    }
}
