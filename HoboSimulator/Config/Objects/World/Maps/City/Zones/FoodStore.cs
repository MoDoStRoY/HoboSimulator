using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Config.Objects.Misc.Items.Food;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HoboSimulator.Config.Objects.World.Maps.City.Zones
{
    class FoodStore : IZone
    {
        String name = "Пятёрочка";
        String description = "Магазин, внешний вид которого резко контрастирует с окружающей обстановкой. Примерно также как принцесса непойми как оказавшаяся на свалке. Однако если зайти внутрь и обратить внимание на персонал и покупателей, то всё сразу встаёт на свои места.\nТут можно купить почти всё необходимое - продукты, вещи, нужные по хозяйству, и даже кое-что из одежды, хоть и, преимущественно, из нижнего белья.";
        String actionTPName = "City_FoodStoreTP";
        int ID = 1;
        Image image = Properties.Resources.City_FoodStore;

        List<IItem> storeAssortment = new List<IItem>
        {
            new Dove(),
            new Dove(),
            new Dove(),
            new Dove(),
            new OpenedWaterBottleSmall(),
            new OpenedWaterBottleSmall(),
            new OpenedWaterBottleSmall(),
            new Scraps(),
            new Scraps(),
            new Scraps()
        };
        List<IItem> chosenGoods = new List<IItem>();

        public String GetName(){return name;}
        public String GetDescription(){return description;}
        public String GetActionTPName(){return actionTPName;}
        public int GetID(){return ID;}
        public Image GetImage(){return image;}
        public List<IItem> GetStoreAssortment(){return storeAssortment;}
        public List<IItem> GetChosenGoods() { return chosenGoods; }
        public void SetStoreAssortment(List<IItem> storeAssortment) { this.storeAssortment = storeAssortment; }
        public void SetChosenGoods(List<IItem> chosenGoods) { this.chosenGoods = chosenGoods; }
        public void AddChosenGoods(int index) { chosenGoods.Add(storeAssortment[index]); storeAssortment.RemoveAt(index); }
        public void DeleteChosenGoods(int index) { storeAssortment.Add(chosenGoods[index]);  chosenGoods.RemoveAt(index); }
    }
}
