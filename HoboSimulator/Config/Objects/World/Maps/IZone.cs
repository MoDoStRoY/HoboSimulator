using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HoboSimulator.Config.Objects.World.Maps
{
    interface IZone
    {
        public String GetName();
        public String GetDescription();
        public String GetActionTPName();
        public int GetID();
        public Image GetImage();
    }
}
