using HoboSimulator.Scripts.Windows.MainGame.Trade;
using System;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game
{
    public partial class TradeWindow : Form
    {
        public TradeWindow()
        {
            InitializeComponent();
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            TradeWindowController.InitializeForm();
        }

        public void ShowWindow()
        {
            TradeWindowController.ShowWindow();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            TradeWindowController.BackBtn();
        }

        private void ChoseGoodDGV(object sender, DataGridViewCellEventArgs e)
        {
            TradeWindowController.ChoseGoodDGV(e);
        }

        private void DeleteGoodDGV(object sender, DataGridViewCellEventArgs e)
        {
            TradeWindowController.DeleteGoodDGV(e);
        }

        private void InfoGoodAssortmentDGV(object sender, DataGridViewCellEventArgs e)
        {
            TradeWindowController.InfoGoodAssortmentDGV(e);
        }

        private void InfoGoodChosenDGV(object sender, DataGridViewCellEventArgs e)
        {
            TradeWindowController.InfoGoodChosenDGV(e);
        }

        private void BuyBtn(object sender, EventArgs e)
        {
            TradeWindowController.BuyBtn();
        }
    }
}
