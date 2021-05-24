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
    public partial class MainMenuWindow : Form
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        private void initializeForm(object sender, EventArgs e)
        {
            MainMenuController.initializeForm();
        }
        
        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public void ShowWindow() // Метод показа формы
        {
            MainMenuController.ShowWindow();
        }

        private void CloseGameBtn(object sender, EventArgs e) // Закрытие формы
        {
            MainMenuController.CloseGameBtn();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        private void ResumeGameBtn(object sender, EventArgs e) // Кнопка возобновления игры
        {
            MainMenuController.ResumeGameBtn();
        }

        private void StartNewGameBtn(object sender, EventArgs e) // Кнопка начала новой игры
        {
            MainMenuController.StartNewGameBtn();
        }

        private void LoadGameBtn(object sender, EventArgs e) // Кнопка загрузки игры
        {
            MainMenuController.LoadGameBtn();
        }

        private void SaveGameBtn(object sender, EventArgs e) // Кнопка сохранения игры
        {
            MainMenuController.SaveGameBtn();
        }

        private void SettingsBtn(object sender, EventArgs e) // Кнопка настроек
        {
            MainMenuController.SettingsBtn();
        }

        //**//
    }
}
