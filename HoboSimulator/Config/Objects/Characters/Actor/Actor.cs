using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Config.Objects.World.Maps;
using HoboSimulator.Scripts.World;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
        public Image icon;
        public String group = "Игрок";

        //**СОСТОЯНИЕ ПЕРСОНАЖА**//

        public int health { get; set; } // Здоровье
        public int thirst { get; set; } // Жажда
        public int hunger { get; set; } // Голод
        public int stamina { get; set; } // Выносливость
        public int sleep { get; set; } // Отдых

        public bool inDialog; // Находится ли в диалоге
        public bool inFight; // Находится ли в сражении

        public int Health{ get { return health; } set { health = NormalizeParams.NormalizeIntParam(value); } }
        public int Thirst { get { return thirst; } set { thirst = NormalizeParams.NormalizeIntParam(value); } }
        public int Hunger { get { return hunger; } set { hunger = NormalizeParams.NormalizeIntParam(value); } }
        public int Stamina { get { return stamina; } set { stamina = NormalizeParams.NormalizeIntParam(value); } }
        public int Sleep { get { return sleep; } set { sleep = NormalizeParams.NormalizeIntParam(value); } }

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
        public double money; // Деньги

        //**МЕСТОПОЛОЖЕНИЕ**//
        public ILocation location; // Локация
        public IZone zone; // Зона локации

        //**КОНТРОЛЬ СОСТОЯНИЙ ПЕРСОНАЖА**//

        public void EditHealth(int value) { health = NormalizeParams.NormalizeIntParam(value); }
        public void EditThirst(int value) { thirst = NormalizeParams.NormalizeIntParam(value); }
        public void EditHunger(int value) { hunger = NormalizeParams.NormalizeIntParam(value); }
        public void EditStamina(int value) { stamina = NormalizeParams.NormalizeIntParam(value); }
        public void EditSleep(int value) { sleep = NormalizeParams.NormalizeIntParam(value); }

        public Actor(String name, int age, String biography, Image icon, int health, int thirst, int hunger, int stamina, int sleep, int skillPoints, List<IItem> inventory, double maxWeight, int money)
        {
            this.name = name;
            this.age = age;
            this.biography = biography;
            this.icon = icon;
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
