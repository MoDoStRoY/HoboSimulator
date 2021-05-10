using HoboSimulator.Config.Objects.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Misc
{
    class Food
    {
        public String name;
        public String description;
        public List<Parameter> parameters = new List<Parameter>
        {
            new Parameter("Сытность", 0),
            new Parameter("Утоление жажды", 0),
            new Parameter("Восстановление стамины", 0),
            new Parameter("Восстановление отдыха", 0)
        };

        public Food() { }

        public Food (String name, String description, List<Parameter> parameters)
        {
            this.name = name;
            this.description = description;
            this.parameters = parameters;
        }
    }
}
