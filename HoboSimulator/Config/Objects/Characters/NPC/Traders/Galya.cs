﻿using HoboSimulator.Config.Assorstsments;
using HoboSimulator.Config.Dialogs;
using HoboSimulator.Config.Dialogs.City.FoodStore;
using HoboSimulator.Config.Objects.Misc.Items;
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
        public Image icon = Properties.Resources.Galya_Icon;
        public List<IItem> inventory = TradeGalya.assortment;
        public List<Dialog> dialog_tree = Galya_Dialogs.dialog_tree;

        public String GetName() { return name; }
        public String GetGroup() { return group; }
        public Image GetIcon() { return icon; }
        public List<IItem> GetInventory() { return inventory; }
        public List<Dialog> GetDialogs() { return dialog_tree; }
    }
}