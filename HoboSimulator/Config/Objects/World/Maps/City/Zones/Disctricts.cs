using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.World.Maps.City.Zones
{
    class Disctricts: IZone
    {
        String name = "Спальный район";
        String description = "Спальный район, вид которого знаком, пожалуй, любому жителю пост-советсткого пространства. Старые хрущёвки, разбитые дороги, уставшие от жизни люди. Пребывая в этом месте будет почти невозможно заметить наступление апокалипсиса или почувствовать хоть какую-то разницу.";
        String actionTPName = "City_DistrictsTP";

        public String GetName()
        {
            return name;
        }

        public String GetDescription()
        {
            return description;
        }

        public String GetActionTPName()
        {
            return actionTPName;
        }
    }
}
