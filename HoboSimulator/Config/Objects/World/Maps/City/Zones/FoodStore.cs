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

        public String GetName()
        {
            return name;
        }

        public String GetDescription()
        {
            return description;
        }

        public String GetActionTPName()
        {
            return actionTPName;
        }

        public int GetID()
        {
            return ID;
        }

        public Image GetImage()
        {
            return image;
        }
    }
}
