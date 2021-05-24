using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Windows.MainGame.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game
{
    public partial class InventoryWindow : Form
    {
        User user = Program.user;

        public InventoryWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public void InitializeForm(object sender, EventArgs e)
        {
            InventoryWindowController.InitializeForm();
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public void ShowWindow() // Метод показа формы
        {
            InventoryWindowController.ShowWindow();
        }

        private void BackBtn(object sender, EventArgs e) // Кнопка "Назад"
        {
            InventoryWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e) // Закрытие формы
        {
            InventoryWindowController.ClosedForm();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        private void UseBtn(object sender, EventArgs e) // Кнопка "Использовать"
        {
            InventoryWindowController.UseBtn();
        }

        private void DropBtn(object sender, EventArgs e) // Кнопка "Выбросить"
        {
            InventoryWindowController.DropBtn();
        }

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        private void ChosenItemDGV(object sender, DataGridViewCellEventArgs e) // Выбор предмета
        {
            InventoryWindowController.ChosenItemDGV(e);
        }

        //**//
    }
}
