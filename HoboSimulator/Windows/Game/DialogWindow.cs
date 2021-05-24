using HoboSimulator.Config.Objects.Characters.NPC;
using HoboSimulator.Scripts.Windows.MainGame;
using System;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game
{
    public partial class DialogWindow : Form
    {
        public DialogWindow()
        {
            InitializeComponent();
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            DialogWindowController.InitializeForm();
        }

        public void ShowWindow(INPC NPC)
        {
            DialogWindowController.ShowWindow(NPC);
        }

        private void BackBtn(object sender, EventArgs e)
        {
            DialogWindowController.BackBtn();
        }

        private void ChoseDialogVariantDGV(object sender, DataGridViewCellEventArgs e)
        {
            DialogWindowController.ChoseDialogVariantDGV(e);
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            DialogWindowController.ClosedForm();
        }
    }
}
