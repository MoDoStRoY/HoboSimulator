﻿using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc
{
    class Food: IItem
    {
        String name;
        String description;
        String type = "Food";
        List<Parameter> parameters;

        public Food(String name, String description, int healthRestore, int thirstSaturation, int satiety, int staminaSaturation, int sleepSaturation, double weight)
        {
            this.name = name;
            this.description = description;
            this.parameters = new List<Parameter>
            {
            new Parameter("Восстановление здоровья", healthRestore),
            new Parameter("Утоление жажды", thirstSaturation),
            new Parameter("Сытность", satiety),
            new Parameter("Восстановление стамины", staminaSaturation),
            new Parameter("Восстановление отдыха", sleepSaturation),
            new Parameter("Вес", weight)
            };
        }

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

        public List<Parameter> GetParamsList()
        {
            return parameters;
        }

    }
}
