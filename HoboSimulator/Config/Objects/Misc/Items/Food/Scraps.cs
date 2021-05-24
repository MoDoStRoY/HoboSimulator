using HoboSimulator.Config.Objects.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc.Items.Food
{
    public class Scraps : IItem
    {
        String name = "Объедки";
        String description = "Выброшенные кем-то объедки. В целом, есть вроде можно, но пахнет это уже подозрительно.";
        String type = "Food";
        bool usable = true;
        int ID = 1;
        public List<Parameter> parameters = new List<Parameter>
        {
            new Parameter("Восстановление здоровья", 0),
            new Parameter("Утоление жажды", 0),
            new Parameter("Сытность", 10),
            new Parameter("Восстановление стамины", 0),
            new Parameter("Восстановление отдыха", 0),
            new Parameter("Вес", 0.3),
            new Parameter("Цена", 50)
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
