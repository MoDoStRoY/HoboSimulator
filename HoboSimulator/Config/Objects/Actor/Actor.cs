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
        public String name; // Имя
        public int age; // Возраст 
        public String biography; // Биография

        //**СОСТОЯНИЕ ПЕРСОНАЖА**//

        public int health; // Здоровье
        public int thirst; // Жажда
        public int hunger; // Голод
        public int stamina; // Выносливость
        public int sleep; // Отдых

        //**НАВЫКИ**//

        public int skillPoints; // Скиллпоинты
        public List<Skill> skills = new List<Skill>() // Скиллы игрока
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
        public IItem chosenItem; // Выбранный предмет в инвентаре (системное)
        public int numberOfChosenItem; // Индекс выбранного предмета в инвентаре (системное)
        public double maxWeight; // Максимальный носимый вес
        public int money; // Деньги

        //**МЕСТОПОЛОЖЕНИЕ**//
        public ILocation location; // Локация
        public IZone zone; // Зона локации

        public Actor(String name, int age, String biography, int health, int thirst, int hunger, int stamina, int sleep, int skillPoints, List<IItem> inventory, double maxWeight, int money)
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
            this.maxWeight = maxWeight;
            this.money = money;
            this.location = user.world.locationList[0];
            this.zone = user.world.locationList[0].GetListOfZones()[0];
        }
    }
}
