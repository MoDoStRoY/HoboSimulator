using HoboSimulator.Config.Assorstsments;
using HoboSimulator.Config.Dialogs;
using HoboSimulator.Config.Dialogs.City.FoodStore;
using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Scripts.World;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HoboSimulator.Config.Objects.Characters.NPC.Traders
{
    public class Galya: INPC
    {
        public String name = "Галя";
        public String group = "Торговец";

        public int health = 100; // Здоровье
        public int stamina = 100; // Выносливость

        public Image icon = Properties.Resources.Galya_Icon; // Иконка
        public List<IItem> inventory = TradeGalya.assortment; // Инвентарь
        public List<Dialog> dialog_tree = Galya_Dialogs.dialog_tree; // Диалоги
        public List<Skill> skills = new List<Skill> // Скиллы
        {
            new Skill("Сила", 1),
            new Skill("Ловкость", 1),
            new Skill("Выносливость", 1),
            new Skill("Ремесло", 5),
            new Skill("Харизма", 2),
            new Skill("Удача", 1)
        };

        public String GetName() { return name; }
        public String GetGroup() { return group; }
        public int GetHealth() { return health; }
        public int GetStamina() { return stamina; }
        public void EditHealth(int health) { this.health += health; this.health = NormalizeParams.NormalizeIntParam(this.health); }
        public void EditStamina(int stamina) { this.stamina += stamina; this.stamina = NormalizeParams.NormalizeIntParam(this.stamina); }
        public Image GetIcon() { return icon; }
        public List<IItem> GetInventory() { return inventory; }
        public List<Dialog> GetDialogs() { return dialog_tree; }
        public List<Skill> GetSkills() { return skills; }
    }
}
