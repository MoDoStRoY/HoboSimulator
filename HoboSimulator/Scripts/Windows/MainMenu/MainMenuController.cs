using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainMenu
{
    class MainMenuController
    {
        static User user = Program.user;

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public static void initializeForm()
        {
            user.mainMenu.fxVersion.Text = Program.user.version;
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public static void ShowWindow() // Метод показа формы
        {
            user.mainMenu.Show();
            initializeForm();
        }

        public static void CloseGameBtn() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        public static void ResumeGameBtn() // Кнопка продолжения игры
        {
            user.mainMenu.Hide();
            user.mainGameWindow.ShowWindow();
        }

        public static void StartNewGameBtn() // Кнопка старта новой игры
        {
            user.mainMenu.Hide();
            user.createActorWindow.Show();
        }

        public static void LoadGameBtn() // Кнопка загрузки игры
        {

        }

        public static void SaveGameBtn() // Кнопка сохранения игры
        {

        }

        public static void SettingsBtn() // Кнопка настроек
        {
            user.settingsWindow.Show();
        }

        //**//
    }
}
