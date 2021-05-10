using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc;
using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.Inventory
{
    class UseItem
    {
        static User user = Program.user;

        public static void UseFood(List<Parameter> parameters)
        {
            user.actor.hunger += parameters[0].value;
            user.actor.thirst += parameters[1].value;
            user.actor.stamina += parameters[2].value;
            user.actor.sleep += parameters[3].value;

            user.actor.inventory.RemoveAt(user.actor.numberOfChosenItem);
        }
    }
}
