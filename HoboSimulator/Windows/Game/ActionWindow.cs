﻿using HoboSimulator.Scripts.Windows.MainGame.Action;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game.Action
{
    public partial class ActionWindow : Form
    {
        public ActionWindow()
        {
            InitializeComponent();
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            ActionWindowController.InitializeForm();
        }

        public void ShowWindow()
        {
            ActionWindowController.ShowWindow();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            ActionWindowController.BackBtn();
        }

        //**КНОПКИ ДЕЙСТВИЙ В ЛОКАЦИИ**//

        //**СПАЛЬНЫЙ РАЙОН**//

        private void HuntBirdBtn(object sender, EventArgs e)
        {
            ActionWindowController.HuntBirdBtn();
        }

        private void LootTrashCanBigBtn(object sender, EventArgs e)
        {
            ActionWindowController.LootTrashCanBigBtn();
        }

        //**ПЯТЁРОЧКА**//

        private void TradeBtn(object sender, EventArgs e)
        {
            ActionWindowController.TradeBtn();
        }

        private void TestDialogBtn(object sender, EventArgs e)
        {
            ActionWindowController.TestDialogBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            ActionWindowController.ClosedForm();
        }
    }
}
