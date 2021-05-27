using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Actions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame.Action
{
    class ActionWindowController
    {
        static User user = Program.user;

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public static void InitializeForm() // Обновление основных параметров и попутно вызов обновления изменяемых
        {
            user.actionWindow.fxNameOfZoneLabel.Text = user.actor.zone.GetName();
            user.actionWindow.fxDescriptionOfZoneText.Text = user.actor.zone.GetDescription();
            user.actionWindow.fxActionsTP.SelectedTab = user.actionWindow.fxActionsTP.TabPages[user.actor.zone.GetActionTPName()];
            user.actionWindow.fxZoneIconPB.Image = user.actor.zone.GetImage();

            UpdateActionVariables();
        }

        public static void UpdateActionVariables() // Обновление изменяемых переменных
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

            InitializeParamsBlock.InitializeParamsBlockAction();
        }

        //**//

        //**ОСНОВЫЕ МЕТОДЫ**//

        public static void ShowWindow() // Метод переключения на эту форму
        {
            user.actionWindow.Show();
            InitializeForm();
        }

        public static void BackBtn() // Кнопка "Назад"
        {
            user.actionWindow.Hide();
            user.mainGameWindow.ShowWindow();
        }

        public static void ClosedForm() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        //**КНОПКИ ДЕЙСТВИЙ В ЛОКАЦИИ**//

        //**СПАЛЬНЫЙ РАЙОН**//
        public static void HuntBirdBtn() //Охота на голубей
        {
            HuntActivity.HuntAction("Ловкость", 0, 0, 3, 2);

            UpdateActionVariables();
        }

        public static void LootTrashCanBigBtn() // Лутание мусорных баков
        {
            LootActivity.LootAction();

            UpdateActionVariables();
        }

        //**//

        //**ПЯТЁРОЧКА**//

        public static void TradeBtn() // Торговля
        {
            user.actionWindow.Hide();
            user.tradeWindow.ShowWindow();
        }

        public static void TestDialogBtn() // Тестовый диалог (нужно удалить)
        {
            user.actionWindow.Hide();
            user.dialogWindow.ShowWindow(user.actor.zone.GetNPCList()[0]);
        }

        public static void TestFightBtn()
        {
            user.actionWindow.Hide();
            user.fightWindow.ShowWindow(user.actor.zone.GetNPCList()[0]);
        }

        //**//

        //**//

        //**//
    }
}
