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

            user.actor.hunger -= distance * 2;
            user.actor.thirst -= distance * 5;
            user.actor.sleep -= 3;
            user.actor.stamina -= (distance * 10) - (user.actor.skills[2].value * 2);

            TimeFlow.AddMinutes((distance * 1000) / (user.actor.skills[2].value * 10));
        }
    }
}
