using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Config.Objects.Misc.Items.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Assorstsments
{
    class TradeGalya
    {
        public static List<IItem> assortment = new List<IItem>
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
    }
}
