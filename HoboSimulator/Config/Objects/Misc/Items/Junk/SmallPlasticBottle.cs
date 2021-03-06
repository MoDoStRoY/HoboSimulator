using HoboSimulator.Config.Objects.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc.Items.Junk
{
    public class SmallPlasticBottle: IItem
    {
        String name = "Пластиковая бутылка (0,5л)";
        String description = "Обыкновенная пластиковая бутылка объёмом 0,5л.\nГрязноватая, немного помята и уже нельзя точно определить, что она содержала в себе изначально, но её до сих пор можно использовать по назначению.";
        String type = "Junk";
        bool usable = false;
        int ID = 3;
        public List<Parameter> parameters = new List<Parameter>
        {
            new Parameter("Вес", 0.03),
            new Parameter("Цена", 5)
        };

        public String GetType(){return type;}
        public String GetName(){return name;}
        public String GetDescription(){return description;}
        public String GetParamsString()
        {
            String result = "";

            for (int i = 0; i < parameters.Count; i++)
                result += "*" + parameters[i].name + ": " + parameters[i].value + "\n";

            return result;
        }
        public bool GetUsable(){return usable;}
        public int GetID(){return ID;}
        public double GetWeight(){return parameters[0].value;}
        public double GetCost(){return parameters[1].value;}
        public List<Parameter> GetParamsList(){return parameters;}
    }
}
