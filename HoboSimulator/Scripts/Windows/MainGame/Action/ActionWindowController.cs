using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.Windows.MainGame.Action
{
    class ActionWindowController
    {
        static User user = Program.user;

        public static void InitializeForm()
        {
            user.actionWindow.fxCurrentTimeLabel.Text = user.world.dateTime.ToString();
            user.actionWindow.fxHealthPB.Value = user.actor.health;
            user.actionWindow.fxHealthLabel.Text = user.actor.health.ToString();
            user.actionWindow.fxThirstPB.Value = user.actor.thirst;
            user.actionWindow.fxThirstLabel.Text = user.actor.thirst.ToString();
            user.actionWindow.fxHungerPB.Value = user.actor.hunger;
            user.actionWindow.fxHungerLabel.Text = user.actor.hunger.ToString();
            user.actionWindow.fxStaminaPB.Value = user.actor.stamina;
            user.actionWindow.fxStaminaLabel.Text = user.actor.stamina.ToString();
            user.actionWindow.fxSleepPB.Value = user.actor.sleep;
            user.actionWindow.fxSleepLabel.Text = user.actor.sleep.ToString();
        }

        public static void ShowWindow()
        {
            user.actionWindow.Show();
            InitializeForm();
        }

        public static void BackBtn()
        {
            user.actionWindow.Hide();
            user.mainGameWindow.ShowWindow();
        }

        //**КНОПКИ ДЕЙСТВИЙ В ЛОКАЦИИ**//

        public static void HuntBirdBtn()
        {
            user.actor.hunger = user.actor.hunger - 5;
            user.actor.thirst = user.actor.thirst - 10;
            user.actor.sleep = user.actor.sleep - 2;
            user.actor.stamina = user.actor.stamina - 30;
            user.world.dateTime = user.world.dateTime.AddHours(1);

            //Нормализация состояний персонажа при выходе за допустимые рамки (далее нужно будет вынести в отдельный скрипт)
            if (user.actor.hunger < 0)
                user.actor.hunger = 0;
            if (user.actor.thirst < 0)
                user.actor.thirst = 0;
            if (user.actor.stamina < 0)
                user.actor.stamina = 0;
            if (user.actor.sleep < 0)
                user.actor.sleep = 0;

            if (user.actor.hunger > 100)
                user.actor.hunger = 100;
            if (user.actor.thirst > 100)
                user.actor.thirst = 100;
            if (user.actor.stamina > 100)
                user.actor.stamina = 100;
            if (user.actor.sleep > 100)
                user.actor.sleep = 100;

            InitializeForm();

            TakeItem.Take("Голубь", "Food");

            user.actionWindow.fxResultOfAction.Text = "Получено: " + GetInfoInventory.GetName(user.actor.inventory[user.actor.inventory.Count - 1]);
        }
    }
}
