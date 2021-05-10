using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.Windows.MainMenu
{
    class MainMenuController
    {

        public static void initializeForm()
        {
            Program.user.mainMenu.fxVersion.Text = Program.user.version;
        }

        public static void StartNewGameBtn()
        {
            Program.user.mainMenu.Hide();
            Program.user.createActorWindow.Show();
        }

        public static void LoadGameBtn()
        {

        }

        public static void SaveGameBtn()
        {

        }

        public static void SettingsBtn()
        {
            Program.user.settingsWindow.Show();
        }

        public static void CloseGameBtn()
        {
            
        }
    }
}
