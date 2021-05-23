using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Actions;
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
            user.actionWindow.fxNameOfZoneLabel.Text = user.actor.zone.GetName();
            user.actionWindow.fxDescriptionOfZoneText.Text = user.actor.zone.GetDescription();
            user.actionWindow.fxActionsTP.SelectedTab = user.actionWindow.fxActionsTP.TabPages[user.actor.zone.GetActionTPName()];
            user.actionWindow.pictureBox1.Image = user.actor.zone.GetImage();

            UpdateActionVariables();
        }

        public static void UpdateActionVariables()
        {
            user.actionWindow.fxHuntBirdTT.SetToolTip(user.actionWindow.fxHuntBirdBtn,
                "Рекомендуемые навыки:\n" +
                "Ловкость: 3\n" +
                "Выносливость: 2");
            user.actionWindow.fxHuntDogTT.SetToolTip(user.actionWindow.fxHuntDogBtn,
                "Рекомендуемые навыки:\n" +
                "Ловкость: 3\n" +
                "Сила: 4");
            user.actionWindow.fxHuntCatTT.SetToolTip(user.actionWindow.fxHuntCatBtn,
                "Рекомендуемые навыки:\n" +
                "Ловкость: 5\n" +
                "Выносливость: 4\n" +
                "Сила: 2");

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

        //**СПАЛЬНЫЙ РАЙОН**//
        public static void HuntBirdBtn()
        {
            HuntActivity.HuntAction("Ловкость", 0, 0, 3, 2);

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

            UpdateActionVariables();
        }

        public static void LootTrashCanBigBtn()
        {
            LootActivity.LootAction();

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

            UpdateActionVariables();
        }

        //**ПЯТЁРОЧКА**//

        public static void TradeBtn()
        {
            user.actionWindow.Hide();
            user.tradeWindow.ShowWindow();
        }
    }
}
