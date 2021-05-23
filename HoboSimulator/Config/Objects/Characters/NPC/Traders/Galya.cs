using HoboSimulator.Config.Assorstsments;
using HoboSimulator.Config.Objects.Misc.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Characters.NPC.Traders
{
    class Galya: INPC
    {
        String name = "Галя";
        String group = "Торговец";
        List<IItem> inventory = null;

        public String GetName() { return name; }
        public String GetGroup() { return group; }
        public List<IItem> GetInventory() { return inventory; }
    }
}
