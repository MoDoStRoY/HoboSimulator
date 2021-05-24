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

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        // Пока не используется

        //**//

        //*ОСНОВНЫЕ МЕТОДЫ*//

        public static void ShowWindow() // Метод показа формы
        {
            user.moveWindow.Show();
        }

        public static void BackBtn() // Кнопка "Назад"
        {
            user.moveWindow.Hide();
            user.mainGameWindow.ShowWindow();
        }

        public static void ClosedForm() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        public static void ToFoodStoreBtn() // Кнопка перемещения персонажа в зону "Пятёрочка"
        {
            if (user.actor.zone.GetID() != 1)
                MoveActivity.MoveInLocation(1, 1);
        }

        public static void ToDistrictsBtn() // Кнопка перемещения персонажа в зону "Спальный район"
        {
            if (user.actor.zone.GetID() != 0)
                MoveActivity.MoveInLocation(1, 0);
        }

        //**//
    }
}
