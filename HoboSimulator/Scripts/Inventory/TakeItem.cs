using HoboSimulator.Config.Objects.Misc;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts
{
    class TakeItem
    {
        static User user = Program.user;

        public static void Take(String name, String type)
        {
            if (type.Equals("Food"))
            {
                if (name.Equals("Голубь"))
                    user.actor.inventory.Add(ItemContructor.GetDove());
                if (name.Equals("Объедки"))
                    user.actor.inventory.Add(ItemContructor.GetScraps());
                if (name.Equals("Початая бутылка воды (0,5л)"))
                    user.actor.inventory.Add(ItemContructor.GetSmallWaterBottle());
            }
            else if (type.Equals("Equipment"))
            {
                if (name.Equals("Пластиковая бутылка 0,5л"))
                    user.actor.inventory.Add(ItemContructor.GetSmallPlasticBottle());
            }
        }
    }
}
