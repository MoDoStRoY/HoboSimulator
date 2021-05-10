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
                    user.actor.inventory.Add(ItemContructor.getDove());
            }
        }
    }
}
