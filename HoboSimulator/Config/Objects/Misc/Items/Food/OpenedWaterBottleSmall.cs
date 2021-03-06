using HoboSimulator.Config.Objects.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc.Items.Food
{
    public class OpenedWaterBottleSmall : IItem
    {
        String name = "Початая бутылка воды (0,5л)";
        String description = "Небольшая початая 0,5л бутылка минералки из пластика. Снаружи грязная и потрёпаная, однако вода внутри вроде чистая, хоть и пахнет уже не очень хорошо.";
        String type = "Food";
        bool usable = true;
        int ID = 2;
        public List<Parameter> parameters = new List<Parameter>
        {
            new Parameter("Восстановление здоровья", 0),
            new Parameter("Утоление жажды", 20),
            new Parameter("Сытность", 2),
            new Parameter("Восстановление стамины", 10),
            new Parameter("Восстановление отдыха", 0),
            new Parameter("Вес", 0.2),
            new Parameter("Цена", 20)
        };

        public String GetType() { return type; }
        public String GetName() { return name; }
        public String GetDescription() { return description; }
        public String GetParamsString()
        {
            String result = "";

            for (int i = 0; i < parameters.Count; i++)
                result += "*" + parameters[i].name + ": " + parameters[i].value + "\n";

            return result;
        }
        public bool GetUsable() { return usable; }
        public int GetID() { return ID; }
        public double GetWeight() { return parameters[0].value; }
        public double GetCost() { return parameters[6].value; }
        public List<Parameter> GetParamsList() { return parameters; }
    }
}
