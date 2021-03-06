using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.Actions
{
    class LootActivity
    {
        static User user = Program.user;
        public static void LootAction()
        {
            Random randomiser = new Random();

            if (randomiser.Next(10) > 5 - user.actor.skills[5].value / 4)
            {
                TakeItem.Take(randomiser.Next(1, 4));

                user.actionWindow.fxResultOfAction.AppendText("Дата и время: " + user.world.dateTime.ToString() + "\n" +
                    "Поиски увенчались успехом! Найдено: " +
                    user.actor.inventory[user.actor.inventory.Count - 1].GetName() + "\n\n");
            }
            else
            {
                user.actionWindow.fxResultOfAction.AppendText("Дата и время: " + user.world.dateTime.ToString() + "\n" +
                    "Тут ничего не удалось найти ничего полезного.\n\n");
            }
            user.actor.Hunger -= 6;
            user.actor.Thirst -= 5;
            user.actor.Sleep -= 3;
            user.actor.Stamina -= 5;

            user.actionWindow.fxResultOfAction.ScrollToCaret();
            TimeFlow.AddMinutes(30);
        }
    }
}
