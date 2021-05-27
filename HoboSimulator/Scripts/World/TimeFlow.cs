using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.World
{
    class TimeFlow
    {
        static User user = Program.user;

        public static void AddNull()
        {
            
        }

        public static void AddMinutes(int min)
        {
            user.world.dateTime = user.world.dateTime.AddMinutes(min);
        }

        public static void AddHours(int hour)
        {
            user.world.dateTime = user.world.dateTime.AddHours(hour);
        }

        public static void AddDays(int day)
        {
            user.world.dateTime = user.world.dateTime.AddDays(day);
        }
    }
}
