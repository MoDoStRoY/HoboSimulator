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

        public void InitializeForm(object sender, EventArgs e)
        {
            InventoryWindowController.InitializeForm();
        }

        public void ShowWindow()
        {
            InventoryWindowController.ShowWindow();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            InventoryWindowController.BackBtn();
        }

        private void ChosenItemDGV(object sender, DataGridViewCellEventArgs e)
        {
            InventoryWindowController.ChosenItemDGV(e);
        }

        private void UseBtn(object sender, EventArgs e)
        {
            InventoryWindowController.UseBtn();
        }

        private void DropBtn(object sender, EventArgs e)
        {
            InventoryWindowController.DropBtn();
        }
    }
}
