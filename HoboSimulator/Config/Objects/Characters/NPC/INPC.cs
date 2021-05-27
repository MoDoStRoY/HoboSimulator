using HoboSimulator.Config.Dialogs;
using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HoboSimulator.Config.Objects.Characters.NPC
{
    public interface INPC
    {
        public String GetName();
        public String GetGroup();
        public int GetHealth();
        public int GetStamina();
        public void EditHealth(int health);
        public void EditStamina(int stamina);
        public Image GetIcon();
        public List<IItem> GetInventory();
        public List<Dialog> GetDialogs();
        public List<Skill> GetSkills();
    }
}
