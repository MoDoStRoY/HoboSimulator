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

            //Нормализация состояний персонажа при выходе за допустимые рамки (далее нужно будет вынести в отдельный скрипт)
            if (user.actor.hunger < 0)
                user.actor.hunger = 0;
            if (user.actor.thirst < 0)
                user.actor.thirst = 0;
            if (user.actor.stamina < 0)
                user.actor.stamina = 0;
            if (user.actor.sleep < 0)
                user.actor.sleep = 0;

            if (user.actor.hunger > 100)
                user.actor.hunger = 100;
            if (user.actor.thirst > 100)
                user.actor.thirst = 100;
            if (user.actor.stamina > 100)
                user.actor.stamina = 100;
            if (user.actor.sleep > 100)
                user.actor.sleep = 100;
        }
    }
}
