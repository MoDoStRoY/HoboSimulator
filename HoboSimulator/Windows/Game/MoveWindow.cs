using HoboSimulator.Scripts.Windows.MainGame.Move;
using System;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game
{
    public partial class MoveWindow : Form
    {
        public MoveWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        // Пока не используется

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public void ShowWindow() // Метод показа формы
        {
            MoveWindowController.ShowWindow();
        }

        private void BackBtn(object sender, EventArgs e) // Кнопка "Назад"
        {
            MoveWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e) // Закрытие формы
        {
            MoveWindowController.ClosedForm();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        private void ToFoodStoreBtn(object sender, EventArgs e) // Кнопка перемещения персонажа в зону "Пятёрочка"
        {
            MoveWindowController.ToFoodStoreBtn();
        }

        private void ToDistrictsBtn(object sender, EventArgs e) // Кнопка перемещения персонажа в зону "Спальный район"
        {
            MoveWindowController.ToDistrictsBtn();
        }

        //**//
    }
}
