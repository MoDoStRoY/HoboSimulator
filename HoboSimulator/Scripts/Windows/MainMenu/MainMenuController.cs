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

        public static void initializeForm()
        {
            user.mainMenu.fxVersion.Text = Program.user.version;
        }

        public static void ResumeGameBtn()
        {
            user.mainMenu.Hide();
            user.mainGameWindow.ShowWindow();
        }

        public static void StartNewGameBtn()
        {
            user.mainMenu.Hide();
            user.createActorWindow.Show();
        }

        public static void LoadGameBtn()
        {

        }

        public static void SaveGameBtn()
        {

        }

        public static void SettingsBtn()
        {
            user.settingsWindow.Show();
        }

        public static void CloseGameBtn()
        {
            Application.Exit();
        }
    }
}
