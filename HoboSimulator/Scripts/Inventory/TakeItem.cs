using HoboSimulator.Config.Objects.Misc;
using HoboSimulator.Config.Objects.Misc.Items.Food;
using HoboSimulator.Config.Objects.Misc.Items.Junk;
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

        public static void Take(int ID)
        {
            switch (ID)
            {
                case 0: { user.actor.inventory.Add(new Dove()); break; }
                case 1: { user.actor.inventory.Add(new Scraps()); break; }
                case 2: { user.actor.inventory.Add(new OpenedWaterBottleSmall()); break; }
                case 3: { user.actor.inventory.Add(new SmallPlasticBottle()); break; }
            }
        }
    }
}
