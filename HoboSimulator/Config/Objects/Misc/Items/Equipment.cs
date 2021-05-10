using HoboSimulator.Config.Objects.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc.Items
{
    class Equipment: IItem
    {
        String name;
        String description;
        String type = "Equipment";
        List<Parameter> parameters;

        public Equipment(String name, String description, double weight)
        {
            this.name = name;
            this.description = description;
            this.parameters = new List<Parameter>
            {
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
