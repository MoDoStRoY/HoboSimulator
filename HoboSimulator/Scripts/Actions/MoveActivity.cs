using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.Actions
{
    class MoveActivity
    {
        static User user = Program.user;

        public static void MoveInLocation(int distance, int zoneID)
        {
            user.actor.zone = user.actor.location.GetListOfZones()[zoneID];

            user.actor.Hunger -= distance * 2;
            user.actor.Thirst -= distance * 5;
            user.actor.Sleep -= 3;
            user.actor.Stamina -= (distance * 10) - (user.actor.skills[2].value * 2);

            TimeFlow.AddMinutes((distance * 1000) / (user.actor.skills[2].value * 10 + 1));
        }
    }
}
