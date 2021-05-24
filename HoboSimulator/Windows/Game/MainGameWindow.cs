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

        private void InitializeForm(object sender, EventArgs e)
        {
            MainGameWindowController.InitializeForm();
        }

        public void ShowWindow()
        {
            MainGameWindowController.ShowWindow();
        }

        private void ActionBtn(object sender, EventArgs e)
        {
            MainGameWindowController.ActionBtn();
        }

        private void MovingBtn(object sender, EventArgs e)
        {
            MainGameWindowController.MovingBtn();
        }

        private void SkillUpCell(object sender, DataGridViewCellEventArgs e)
        {
            MainGameWindowController.SkillUpCell(e);
        }

        private void MenuBtn(object sender, EventArgs e)
        {
            MainGameWindowController.MenuBtn();
        }

        private void InventoryBtn(object sender, EventArgs e)
        {
            MainGameWindowController.InventoryBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            MainGameWindowController.ClosedForm();
        }
    }
}
