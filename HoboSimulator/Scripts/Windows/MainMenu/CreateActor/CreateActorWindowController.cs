using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.CreateActor
{
    class CreateActorWindowController
    {
        static User user = Program.user;

        public static void InitializeForm()
        {
            user.createActorWindow.fxListOfPresets.Items.Add("Перхоть");
            user.createActorWindow.fxListOfPresets.Items.Add("Гомункул");
            user.createActorWindow.fxListOfPresets.Items.Add("Крыса");
            user.createActorWindow.fxListOfPresets.Items.Add("Чурка");
        }

        public static void EndCreateBtn()
        {
            user.actor = new Actor(user.createActorWindow.fxName.Text, //Имя 
                Convert.ToInt32(user.createActorWindow.fxAge.Text), // Возраст 
                user.createActorWindow.fxBiography.Text,  // Биография
                100, // Здоровье
                100, // Питьё
                100, // Сытость
                100, // Выносливость
                100, // Сон
                10, // Скиллпоинты
                new List<object>()
                );
            user.createActorWindow.Hide();
            user.mainGameWindow.ShowWindow();
        }

        public static void HoboPresetChosenLB()
        {

        }
    }
}
