using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.World
{
    class TimeFlow
    {
        static User user = Program.user;

        public static void NormalizeParams()
        {
            if (user.actor.hunger < 0)
                user.actor.hunger = 0;
            if (user.actor.thirst < 0)
                user.actor.thirst = 0;
            if (user.actor.stamina < 0)
                user.actor.stamina = 0;
            if (user.actor.sleep < 0)
                user.actor.sleep = 0;

            if (user.actor.hunger > 100)
                user.actor.hunger = 100;
            if (user.actor.thirst > 100)
                user.actor.thirst = 100;
            if (user.actor.stamina > 100)
                user.actor.stamina = 100;
            if (user.actor.sleep > 100)
                user.actor.sleep = 100;
        }

        public static void AddNull()
        {
            NormalizeParams();
        }

        public static void AddMinutes(int min)
        {
            user.world.dateTime = user.world.dateTime.AddMinutes(min);

            NormalizeParams();
        }

        public static void AddHours(int hour)
        {
            user.world.dateTime = user.world.dateTime.AddHours(hour);

            NormalizeParams();
        }

        public static void AddDays(int day)
        {
            user.world.dateTime = user.world.dateTime.AddDays(day);

            NormalizeParams();
        }
    }
}
