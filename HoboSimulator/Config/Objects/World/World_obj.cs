using HoboSimulator.Config.Objects.Characters.NPC;
using HoboSimulator.Config.Objects.World.Maps;
using HoboSimulator.Config.Objects.World.Maps.City;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.World
{
    class World_obj
    {
        public DateTime dateTime; // Текущая игровая дата и время

        public List<ILocation> locationList = new List<ILocation>
        {
            new City()
        };

        public World_obj (DateTime dateTime)
        {
            this.dateTime = dateTime;
        }
    }
}
