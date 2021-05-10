using HoboSimulator.Config.Objects.World.Maps;
using HoboSimulator.Config.Objects.World.Maps.City;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.World
{
    class World
    {
        public DateTime dateTime; // Текущая игровая дата и время

        public List<ILocation> locationList = new List<ILocation>
        {
            new City()
        };

        public World (DateTime dateTime)
        {
            this.dateTime = dateTime;
        }
    }
}
