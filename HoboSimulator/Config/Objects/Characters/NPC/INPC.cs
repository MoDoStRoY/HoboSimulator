using HoboSimulator.Config.Objects.Misc.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Characters.NPC
{
    interface INPC
    {
        public String GetName();
        public String GetGroup();
        public List<IItem> GetInventory();
    }
}
