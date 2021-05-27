using HoboSimulator.Config.Objects.Misc.Items;
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
    public partial class LootWindow : Form
    {
        public LootWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public void InitializeForm(object sender, EventArgs e)
        {
            LootWindowController.InitializeForm();
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public void ShowWindow(List<IItem> lootIn) // Метод показа формы
        {
            LootWindowController.ShowWindow(lootIn);
        }

        private void BackBtn(object sender, EventArgs e) // Кнопка "Назад"
        {
            LootWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e) // Закрытие формы
        {
            LootWindowController.ClosedForm();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//



        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        private void InfoItemFromLootDGV(object sender, DataGridViewCellEventArgs e)
        {
            LootWindowController.InfoItemFromLootDGV(e);
        }

        private void ChoseItemFromLootDGV(object sender, DataGridViewCellEventArgs e)
        {
            LootWindowController.ChoseItemFromLootDGV(e);
        }

        private void InfoItemFromInventoryDGV(object sender, DataGridViewCellEventArgs e)
        {
            LootWindowController.InfoItemFromInventoryDGV(e);
        }

        private void DeleteItemFromInventoryDGV(object sender, DataGridViewCellEventArgs e)
        {
            LootWindowController.DeleteItemFromInventoryDGV(e);
        }

        //**//
    }
}
