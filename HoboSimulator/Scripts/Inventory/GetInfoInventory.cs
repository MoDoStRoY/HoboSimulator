using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts
{
    class GetInfoInventory
    {
        static Food itemFood;

        public static String GetType(object item)
        {
            if (item is Food)
            {
                return "Food";
            }

            return null;
        }

        public static String GetName(object item)
        {
            if (item is Food)
            {
                itemFood = (Food)item;
                return itemFood.name;
            }

            return null;
        }

        public static String GetDescription(object item)
        {
            if (item is Food)
            {
                itemFood = (Food)item;
                return itemFood.description;
            }

            return null;
        }

        public static String GetParamsString(object item)
        {
            if (item is Food)
            {
                itemFood = (Food)item;
                String result = "";

                for (int i = 0; i < itemFood.parameters.Count; i++)
                    result = result + itemFood.parameters[i].name + ": " + itemFood.parameters[i].value + "\n";

                return result;
            }

            return null;
        }

        public static List<Parameter> GetParamsList(object item)
        {
            if (item is Food)
            {
                itemFood = (Food)item;

                return itemFood.parameters;
            }

            return null;
        }
    }
}
