using HoboSimulator.Config.Objects.System;
using HoboSimulator.Windows.Game;
using HoboSimulator.Windows.Game.Action;
using HoboSimulator.Windows.Game.CreateActor;
using HoboSimulator.Windows.Game.MainGame;
using HoboSimulator.Windows.MainMenu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows
{
    class InitializeParamsBlock
    {
        static User user = Program.user;

        public static void InitializeParamsBlockMainGame() //Главное игровое окно
        {
            user.mainGameWindow.fxCurrentTimeLabel.Text = user.world.dateTime.ToString();
            user.mainGameWindow.fxMoneyLabel.Text = user.actor.money.ToString();
            user.mainGameWindow.fxHealthPB.Value = user.actor.health;
            user.mainGameWindow.fxHealthLabel.Text = user.actor.health.ToString();
            user.mainGameWindow.fxThirstPB.Value = user.actor.thirst;
            user.mainGameWindow.fxThirstLabel.Text = user.actor.thirst.ToString();
            user.mainGameWindow.fxHungerPB.Value = user.actor.hunger;
            user.mainGameWindow.fxHungerLabel.Text = user.actor.hunger.ToString();
            user.mainGameWindow.fxStaminaPB.Value = user.actor.stamina;
            user.mainGameWindow.fxStaminaLabel.Text = user.actor.stamina.ToString();
            user.mainGameWindow.fxSleepPB.Value = user.actor.sleep;
            user.mainGameWindow.fxSleepLabel.Text = user.actor.sleep.ToString();
        }

        public static void InitializeParamsBlockAction() //Окно действий
        {
            user.actionWindow.fxCurrentTimeLabel.Text = user.world.dateTime.ToString();
            user.actionWindow.fxMoneyLabel.Text = user.actor.money.ToString();
            user.actionWindow.fxHealthPB.Value = user.actor.health;
            user.actionWindow.fxHealthLabel.Text = user.actor.health.ToString();
            user.actionWindow.fxThirstPB.Value = user.actor.thirst;
            user.actionWindow.fxThirstLabel.Text = user.actor.thirst.ToString();
            user.actionWindow.fxHungerPB.Value = user.actor.hunger;
            user.actionWindow.fxHungerLabel.Text = user.actor.hunger.ToString();
            user.actionWindow.fxStaminaPB.Value = user.actor.stamina;
            user.actionWindow.fxStaminaLabel.Text = user.actor.stamina.ToString();
            user.actionWindow.fxSleepPB.Value = user.actor.sleep;
            user.actionWindow.fxSleepLabel.Text = user.actor.sleep.ToString();
        }

        public static void InitializeParamsBlockDialog() //Окно диалога
        {
            user.dialogWindow.fxCurrentTimeLabel.Text = user.world.dateTime.ToString();
            user.dialogWindow.fxMoneyLabel.Text = user.actor.money.ToString();
            user.dialogWindow.fxHealthPB.Value = user.actor.health;
            user.dialogWindow.fxHealthLabel.Text = user.actor.health.ToString();
            user.dialogWindow.fxThirstPB.Value = user.actor.thirst;
            user.dialogWindow.fxThirstLabel.Text = user.actor.thirst.ToString();
            user.dialogWindow.fxHungerPB.Value = user.actor.hunger;
            user.dialogWindow.fxHungerLabel.Text = user.actor.hunger.ToString();
            user.dialogWindow.fxStaminaPB.Value = user.actor.stamina;
            user.dialogWindow.fxStaminaLabel.Text = user.actor.stamina.ToString();
            user.dialogWindow.fxSleepPB.Value = user.actor.sleep;
            user.dialogWindow.fxSleepLabel.Text = user.actor.sleep.ToString();
        }

        public static void InitializeParamsBlockInventory() // Окно инвентаря
        {
            user.inventoryWindow.fxCurrentTimeLabel.Text = user.world.dateTime.ToString();
            user.inventoryWindow.fxMoneyLabel.Text = user.actor.money.ToString();
            user.inventoryWindow.fxHealthPB.Value = user.actor.health;
            user.inventoryWindow.fxHealthLabel.Text = user.actor.health.ToString();
            user.inventoryWindow.fxThirstPB.Value = user.actor.thirst;
            user.inventoryWindow.fxThirstLabel.Text = user.actor.thirst.ToString();
            user.inventoryWindow.fxHungerPB.Value = user.actor.hunger;
            user.inventoryWindow.fxHungerLabel.Text = user.actor.hunger.ToString();
            user.inventoryWindow.fxStaminaPB.Value = user.actor.stamina;
            user.inventoryWindow.fxStaminaLabel.Text = user.actor.stamina.ToString();
            user.inventoryWindow.fxSleepPB.Value = user.actor.sleep;
            user.inventoryWindow.fxSleepLabel.Text = user.actor.sleep.ToString();
        }

        public static void InitializeParamsBlockTrade() //Окно торговли
        { 
            user.tradeWindow.fxCurrentTimeLabel.Text = user.world.dateTime.ToString();
            user.tradeWindow.fxMoneyLabel.Text = user.actor.money.ToString();
            user.tradeWindow.fxHealthPB.Value = user.actor.health;
            user.tradeWindow.fxHealthLabel.Text = user.actor.health.ToString();
            user.tradeWindow.fxThirstPB.Value = user.actor.thirst;
            user.tradeWindow.fxThirstLabel.Text = user.actor.thirst.ToString();
            user.tradeWindow.fxHungerPB.Value = user.actor.hunger;
            user.tradeWindow.fxHungerLabel.Text = user.actor.hunger.ToString();
            user.tradeWindow.fxStaminaPB.Value = user.actor.stamina;
            user.tradeWindow.fxStaminaLabel.Text = user.actor.stamina.ToString();
            user.tradeWindow.fxSleepPB.Value = user.actor.sleep;
            user.tradeWindow.fxSleepLabel.Text = user.actor.sleep.ToString();
        }
    }
}
