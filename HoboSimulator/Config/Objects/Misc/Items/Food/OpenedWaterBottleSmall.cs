﻿using HoboSimulator.Config.Objects.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc.Items.Food
{
    class OpenedWaterBottleSmall : IItem
    {
        String name = "Початая бутылка воды (0,5л)";
        String description = "Небольшая початая 0,5л бутылка минералки из пластика. Снаружи грязная и потрёпаная, однако вода внутри вроде чистая, хоть и пахнет уже не очень хорошо.";
        String type = "Food";
        int ID = 2;
        List<Parameter> parameters = new List<Parameter>
        {
            new Parameter("Восстановление здоровья", 0),
            new Parameter("Утоление жажды", 20),
            new Parameter("Сытность", 2),
            new Parameter("Восстановление стамины", 10),
            new Parameter("Восстановление отдыха", 0),
            new Parameter("Вес", 0.2)
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

        public List<Parameter> GetParamsList()
        {
            return parameters;
        }
    }
}