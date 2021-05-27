using HoboSimulator.Config.Objects.Characters.NPC;
using HoboSimulator.Scripts.Windows.MainGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game
{
    public partial class FightWindow : Form
    {
        public FightWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//
        //В данном случае не используется, т.к. форма открывается через ShowWindow, вызывающий инициализацию//
        private void InitializeForm(object sender, EventArgs e)
        {
            FightWindowController.InitializeForm();
        }

        //**//

        //**ОСНОВЫЕ МЕТОДЫ**//

        public void ShowWindow(INPC NPC) // Метод показа этой формы
        {
            FightWindowController.ShowWindow(NPC);
        }

        public void RShowWindow() // Метод показа этой формы
        {
            FightWindowController.RShowWindow();
        }

        private void BackBtn(object sender, EventArgs e) // Кнопка "Назад"
        {
            FightWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e) // Закрытие формы
        {
            FightWindowController.ClosedForm();
        }

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        // Пока не используется

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        // Пока не используется

        //**//
    }
}
