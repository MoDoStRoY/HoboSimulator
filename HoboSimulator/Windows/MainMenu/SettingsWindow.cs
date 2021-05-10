using HoboSimulator.Scripts.Windows.MainMenu.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Windows.MainMenu
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            SettingsWindowController.InitializeForm();
        }

        private void ShowWindow()
        {
            Show();
            SettingsWindowController.InitializeForm();
        }

        private void GraphicsBtn(object sender, EventArgs e)
        {
            SettingsWindowController.GraphicsBtn();
        }

        private void SoundBtn(object sender, EventArgs e)
        {
            SettingsWindowController.SoundBtn();
        }

        private void GameBtn(object sender, EventArgs e)
        {
            SettingsWindowController.GameBtn();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            SettingsWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            SettingsWindowController.ClosedForm();
        }
    }
}
