using HoboSimulator.Config.Objects.World.Maps.City.Zones;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.World.Maps.City
{
    class City : ILocation
    {
        String name = "Город";
        int ID = 0;
        List<IZone> listOfZones = new List<IZone>
        {
            new Disctricts(),
            new FoodStore()
        };

        public String GetName()
        {
            return name;
        }

        public int GetID()
        {
            return ID;
        }

        public List<IZone> GetListOfZones()
        {
            return listOfZones;
        }
    }
}
