using HoboSimulator.Scripts.Windows.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoboSimulator
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void initializeForm(object sender, EventArgs e)
        {
            MainMenuController.initializeForm();
        }

        private void ShowWindow()
        {
            Show();
            MainMenuController.initializeForm();
        }

        private void StartNewGameBtn(object sender, EventArgs e)
        {
            MainMenuController.StartNewGameBtn();
        }

        private void LoadGameBtn(object sender, EventArgs e)
        {
            MainMenuController.LoadGameBtn();
        }

        private void SaveGameBtn(object sender, EventArgs e)
        {
            MainMenuController.SaveGameBtn();
        }

        private void SettingsBtn(object sender, EventArgs e)
        {
            MainMenuController.SettingsBtn();
        }

        private void CloseGameBtn(object sender, EventArgs e)
        {
            MainMenuController.CloseGameBtn();
        }

        private void ResumeGameBtn(object sender, EventArgs e)
        {
            MainMenuController.ResumeGameBtn();
        }
    }
}
