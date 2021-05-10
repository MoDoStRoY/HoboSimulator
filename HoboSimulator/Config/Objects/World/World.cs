using HoboSimulator.Config.Objects.World.Maps;
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
            new City("Тестовая локация")
        };

        public World (DateTime dateTime)
        {
            this.dateTime = dateTime;
        }
    }
}
