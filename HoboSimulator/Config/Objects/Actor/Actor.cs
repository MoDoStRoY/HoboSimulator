using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Actor
{
    class Actor
    {
        //**БИОГРАФИЧЕСКИЕ ПАРАМЕТРЫ**//
        public String name;
        public int age;
        public String biography;

        //**СОСТОЯНИЕ ПЕРСОНАЖА**//

        public int health;
        public int thirst;
        public int hunger;
        public int stamina;
        public int sleep;

        //**НАВЫКИ**//

        public int skillPoints;
        public List<Parameter> skills = new List<Parameter>()
        {
            new Parameter("Сила", 0),
            new Parameter("Харизма", 0),
            new Parameter("Удача", 0)
        };

        //**ИНВЕНТАРЬ**//

        public List<object> inventory; // Инвентарь
        public object chosenItem; // Выбранный предмет в инвентаре
        public int numberOfChosenItem; // Индекс выбранного предмета в инвентаре

        public Actor(String name, int age, String biography, int health, int thirst, int hunger, int stamina, int sleep, int skillPoints, List<object> inventory)
        {
            this.name = name;
            this.age = age;
            this.biography = biography;
            this.health = health;
            this.thirst = thirst;
            this.hunger = hunger;
            this.stamina = stamina;
            this.sleep = sleep;
            this.skillPoints = skillPoints;
            this.inventory = inventory;
        }
    }
}
