using HoboSimulator.Config.Objects.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc.Items
{
    public interface IItem
    {
        public String GetType();
        public String GetName();
        public String GetDescription();
        public String GetParamsString();
        public int GetID();
        public double GetWeight();
        public double GetCost();
        public List<Parameter> GetParamsList();
    }
}
