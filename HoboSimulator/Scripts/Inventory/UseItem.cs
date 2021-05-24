using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.World;
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
            user.actor.health += (int)parameters[0].value;
            user.actor.thirst += (int)parameters[1].value;
            user.actor.hunger += (int)parameters[2].value;
            user.actor.stamina += (int)parameters[3].value;
            user.actor.sleep += (int)parameters[4].value;

            user.actor.inventory.RemoveAt(user.actor.numberOfChosenItem);

            TimeFlow.AddNull();
        }
    }
}
