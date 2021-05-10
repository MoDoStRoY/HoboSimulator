using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Config.Objects.World.Maps;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Objects.Actor
{
    class Actor
    {
        static User user = Program.user;

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
        public List<Skill> skills = new List<Skill>()
        {
            new Skill("Сила", 0),
            new Skill("Ловкость", 0),
            new Skill("Выносливость", 0),
            new Skill("Ремесло", 0),
            new Skill("Харизма", 0),
            new Skill("Удача", 0)
        };

        //**ИНВЕНТАРЬ**//

        public List<IItem> inventory; // Инвентарь
        public IItem chosenItem; // Выбранный предмет в инвентаре
        public int numberOfChosenItem; // Индекс выбранного предмета в инвентаре

        //**МЕСТОПОЛОЖЕНИЕ**//
        public ILocation location;
        public IZone zone;

        public Actor(String name, int age, String biography, int health, int thirst, int hunger, int stamina, int sleep, int skillPoints, List<IItem> inventory)
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
            this.location = user.world.locationList[0];
            this.zone = user.world.locationList[0].GetListOfZones()[0];
        }
    }
}
