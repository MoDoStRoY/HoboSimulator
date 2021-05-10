using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.Actions
{
    class Activities
    {
        static User user = Program.user;

        public static void HuntAction(String priorety, String target, int powerCondition, int agilityCondition, int staminaCondition)
        {
            Random randomiser = new Random();

            int powerResult = user.actor.skills[0].value - powerCondition;
            int agilityResult = user.actor.skills[1].value - agilityCondition;
            int staminaResult = user.actor.skills[2].value - staminaCondition;

            if (priorety.Equals("Ловкость"))
            {
                if (randomiser.Next(10) > 5 - agilityResult - (staminaResult/2))
                {
                    TakeItem.Take(target, "Food");

                    user.actionWindow.fxResultOfAction.Text += "Дата и время: " + user.world.dateTime.ToString() + "\n" +
                        "Охота успешна! Добыто: " +
                        user.actor.inventory[user.actor.inventory.Count - 1].GetName() + "\n\n";
                }
                else 
                {
                    user.actionWindow.fxResultOfAction.Text += "Дата и время: " + user.world.dateTime.ToString() + "\n" +
                        "Охота не удалась - ничего не добыто.\n\n";
                }
                user.actor.hunger -= 10 - (agilityResult + staminaResult)/2;
                user.actor.thirst -= 20 - (agilityResult + staminaResult)/2;
                user.actor.sleep -= 3;
                user.actor.stamina -= 20 - (agilityResult + staminaResult)/2;
            }
            else if (priorety.Equals("Сила"))
            {
                if (randomiser.Next(10) > 5 - agilityResult - (staminaResult / 2))
                {
                    TakeItem.Take(target, "Food");
                }
                else
                {

                }
            }
            user.world.dateTime = user.world.dateTime.AddMinutes(30);
        }

        public static void LootAction()
        {
            Random randomiser = new Random();

            if (randomiser.Next(10) > 5 - user.actor.skills[5].value/4)
            {
                int indexOfResult = randomiser.Next(1, 4);
                String[] buffer = ItemContructor.listOfItems[indexOfResult].Split("|");

                TakeItem.Take(buffer[0], buffer[1]);

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
