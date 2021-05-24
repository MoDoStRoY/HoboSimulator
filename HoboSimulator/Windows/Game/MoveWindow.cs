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

        public void ShowWindow()
        {
            MoveWindowController.ShowWindow();
        }

        private void ToFoodStoreBtn(object sender, EventArgs e)
        {
            MoveWindowController.ToFoodStoreBtn();
        }

        private void ToDistrictsBtn(object sender, EventArgs e)
        {
            MoveWindowController.ToDistrictsBtn();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            MoveWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            MoveWindowController.ClosedForm();
        }
    }
}
