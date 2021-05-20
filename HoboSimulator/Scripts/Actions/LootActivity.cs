using HoboSimulator.Config.Objects.System;
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

                user.actionWindow.fxResultOfAction.Text += "Дата и время: " + user.world.dateTime.ToString() + "\n" +
                    "Поиски увенчались успехом! Найдено: " +
                    user.actor.inventory[user.actor.inventory.Count - 1].GetName() + "\n\n";
            }
            else
            {
                user.actionWindow.fxResultOfAction.Text += "Дата и время: " + user.world.dateTime.ToString() + "\n" +
                    "Тут ничего не удалось найти ничего полезного.\n\n";
            }
            user.actor.hunger -= 6;
            user.actor.thirst -= 5;
            user.actor.sleep -= 3;
            user.actor.stamina -= 5;

            user.world.dateTime = user.world.dateTime.AddMinutes(30);
        }
    }
}
