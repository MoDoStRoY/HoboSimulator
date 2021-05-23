using HoboSimulator.Config.Objects.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc.Items.Food
{
    class Dove: IItem
    {
        String name = "Голубь";
        String description = "Тушка мёртвого голубя, пока свежая.\nСырая, не выпотрошенная и не ощипанная - лучше приготовить перед употреблением.";
        String type = "Food";
        int ID = 0;
        List<Parameter> parameters = new List<Parameter>
        {
            new Parameter("Восстановление здоровья", 0),
            new Parameter("Утоление жажды", 5),
            new Parameter("Сытность", 25),
            new Parameter("Восстановление стамины", 0),
            new Parameter("Восстановление отдыха", 0),
            new Parameter("Вес", 0.3),
            new Parameter("Цена", 100)
        };

        public String GetType()
        {
            return type;
        }

        public String GetName()
        {
            return name;
        }

        public String GetDescription()
        {
            return description;
        }

        public String GetParamsString()
        {
            String result = "";

            for (int i = 0; i < parameters.Count; i++)
                result += "*" + parameters[i].name + ": " + parameters[i].value + "\n";

            return result;
        }

        public int GetID()
        {
            return ID;
        }

        public double GetWeight()
        {
            return parameters[5].value;
        }

        public double GetCost()
        {
            return parameters[6].value;
        }

        public List<Parameter> GetParamsList()
        {
            return parameters;
        }
    }
}
