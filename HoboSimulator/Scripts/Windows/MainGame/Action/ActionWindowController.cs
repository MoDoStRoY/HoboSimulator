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

            InitializeForm();

            TakeItem.Take("Голубь", "Food");

            user.actionWindow.fxResultOfAction.Text = "Получено: " + GetInfoInventory.GetName(user.actor.inventory[user.actor.inventory.Count-1]);
        }
    }
}
