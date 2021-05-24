using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Dialogs.City.FoodStore
{
    class Galya_Dialogs
    {
        public static List<Dialog> dialog_tree = new List<Dialog>
        {
            new Dialog("Это тестовый диалог.",
                "Ясно.",
                new List<Dialog>
                {
                    new Dialog("И что дальше?",
                        "Не знаю",
                        null),
                    new Dialog("Ты пидор.",
                        "А может быть это ты пидор?",
                        null)
                }),
        };
    }
}
