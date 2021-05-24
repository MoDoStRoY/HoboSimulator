using HoboSimulator.Windows.MainMenu;
using System;
using System.Collections.Generic;
using System.Text;
using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Windows.Game.CreateActor;
using HoboSimulator.Windows.Game.MainGame;
using HoboSimulator.Windows.Game.Action;
using HoboSimulator.Windows.Game;

namespace HoboSimulator.Config.Objects.System
{
    class User
    {
        //**ОБЩИЕ ПЕРЕМЕННЫЕ**//

        public String version = "0.1.0";
        public MainMenu mainMenu = new MainMenu();
        public SettingsWindow settingsWindow = new SettingsWindow();
        public CreateActorWindow createActorWindow = new CreateActorWindow();
        public MainGameWindow mainGameWindow = new MainGameWindow();
        public ActionWindow actionWindow = new ActionWindow();
        public InventoryWindow inventoryWindow = new InventoryWindow();
        public MoveWindow moveWindow = new MoveWindow();
        public TradeWindow tradeWindow = new TradeWindow();
        public DialogWindow dialogWindow = new DialogWindow();

        //**Игровые переменные**//

        public Actor.Actor actor;
        public World.World_obj world;
    }
}
