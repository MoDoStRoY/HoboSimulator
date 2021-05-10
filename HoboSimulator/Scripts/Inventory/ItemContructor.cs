using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.Inventory
{
    class ItemContructor
    {
        public static object getDove()
        {
            Food Dove = new Food();
            Dove.name = "Голубь";
            Dove.description = "Обычный сочный голубь. Правда сырой и с перьями, лучше его приготовить.";

            Dove.parameters[0].value = 2; //Сытность
            Dove.parameters[1].value = 20; // Утоление жажды
            Dove.parameters[2].value = 20; // Восстановление стамины
            Dove.parameters[3].value = 2; // Восстановление отдыха

            return Dove;
        }
    }
}
