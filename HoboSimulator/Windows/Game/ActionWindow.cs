using HoboSimulator.Scripts.Windows.MainGame.Action;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game.Action
{
    public partial class ActionWindow : Form
    {
        public ActionWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        private void InitializeForm(object sender, EventArgs e)
        {
            ActionWindowController.InitializeForm();
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ ФОРМЫ**//

        public void ShowWindow() // Метод показа окна
        {
            ActionWindowController.ShowWindow();
        }

        private void BackBtn(object sender, EventArgs e) // Кнопка "Назад"
        {
            ActionWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e) // Закрытие формы
        {
            ActionWindowController.ClosedForm();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        //**КНОПКИ ДЕЙСТВИЙ В ЛОКАЦИИ**//

        //**СПАЛЬНЫЙ РАЙОН**//

        private void HuntBirdBtn(object sender, EventArgs e) // Охота на голубей
        {
            ActionWindowController.HuntBirdBtn();
        }

        private void LootTrashCanBigBtn(object sender, EventArgs e) // Лутание мусорных баков
        {
            ActionWindowController.LootTrashCanBigBtn();
        }

        //**//

        //**ПЯТЁРОЧКА**//

        private void TradeBtn(object sender, EventArgs e) // Торговля
        {
            ActionWindowController.TradeBtn();
        }

        private void TestDialogBtn(object sender, EventArgs e) // Тестовый диалог (нужно удалить)
        {
            ActionWindowController.TestDialogBtn();
        }

        private void TestFightBtn(object sender, EventArgs e)
        {
            ActionWindowController.TestFightBtn();
        }

        //**//

        //**//

        //**//
    }
}
