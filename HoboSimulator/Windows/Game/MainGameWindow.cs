using HoboSimulator.Scripts.Windows.CreateActor;
using HoboSimulator.Scripts.Windows.MainGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game.MainGame
{
    public partial class MainGameWindow : Form
    {
        public MainGameWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//
        
        private void InitializeForm(object sender, EventArgs e)
        {
            MainGameWindowController.InitializeForm();
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public void ShowWindow() // Метод показа формы
        {
            MainGameWindowController.ShowWindow();
        }

        private void MenuBtn(object sender, EventArgs e) // Кнопка "Меню"
        {
            MainGameWindowController.MenuBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e) // Метод закрытия формы
        {
            MainGameWindowController.ClosedForm();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        private void ActionBtn(object sender, EventArgs e) // Кнопка перехода в форму действий
        {
            MainGameWindowController.ActionBtn();
        }

        private void MovingBtn(object sender, EventArgs e) // Кнопка перехода в форму перемещений
        {
            MainGameWindowController.MovingBtn();
        }

        private void InventoryBtn(object sender, EventArgs e) // Кнопка перехода в форму инвентаря
        {
            MainGameWindowController.InventoryBtn();
        }

        private void ResumeDialogBtn(object sender, EventArgs e) // Кнопка возврата в форму диалога
        {
            MainGameWindowController.ResumeDialogBtn();
        }

        private void ResumeFightBtn(object sender, EventArgs e) // Кнопка возврата в форму сражения
        {
            MainGameWindowController.ResumeFightBtn();
        }

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        private void SkillUpCell(object sender, DataGridViewCellEventArgs e) // Прокачка скилла
        {
            MainGameWindowController.SkillUpCell(e);
        }

        //**//
    }
}
