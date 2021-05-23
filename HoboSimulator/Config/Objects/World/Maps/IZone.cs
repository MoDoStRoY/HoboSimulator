using HoboSimulator.Config.Objects.Misc.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HoboSimulator.Config.Objects.World.Maps
{
    interface IZone
    {
        public String GetName();
        public String GetDescription();
        public String GetActionTPName();
        public int GetID();
        public Image GetImage();
        public List<IItem> GetStoreAssortment();
        public List<IItem> GetChosenGoods();
        public void SetStoreAssortment(List<IItem> storeAssortment);
        public void SetChosenGoods(List<IItem> chosenGoods);
        public void AddChosenGoods(int index);
        public void DeleteChosenGoods(int index);
    }
}
