using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Actions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame.Move
{
    class MoveWindowController
    {
        static User user = Program.user;

        public static void ShowWindow()
        {
            user.moveWindow.Show();
        }

        public static void ToFoodStoreBtn()
        {
            if (user.actor.zone.GetID() != 1)
                MoveActivity.MoveInLocation(1, 1);
        }

        public static void ToDistrictsBtn()
        {
            if (user.actor.zone.GetID() != 0)
                MoveActivity.MoveInLocation(1, 0);
        }

        public static void BackBtn()
        {
            user.moveWindow.Hide();
            user.mainGameWindow.ShowWindow();
        }

        public static void ClosedForm()
        {
            Application.Exit();
        }
    }
}
