using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Inventory;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame.Inventory
{
    class InventoryWindowController
    {
        static User user = Program.user;

        public static void InitializeForm()
        {
            user.inventoryWindow.fxCurrentTimeLabel.Text = user.world.dateTime.ToString();

            double weight = 0;
            for (int i = 0; i < user.actor.inventory.Count; i++)
                weight += user.actor.inventory[i].GetWeight();
            user.inventoryWindow.fxWeightLabel.Text = weight + " кг";
            user.inventoryWindow.fxMaxWeightLabel.Text = user.actor.maxWeight + " кг";
            user.inventoryWindow.fxMoneyLabel.Text = user.actor.money + " руб.";

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
            user.inventoryWindow.fxInventoryDGV.Rows.Clear();
            user.inventoryWindow.fxNameOfItemLabel.Text = "";
            user.inventoryWindow.fxDescriptionOfItemText.Text = "";
            user.inventoryWindow.fxTtxText.Text = "";
            user.inventoryWindow.fxUseBtn.Visible = false;
            user.inventoryWindow.fxDropBtn.Visible = false;

            if (user.actor.inventory.Count > 0)
            {
                for (int i = 0; i < user.actor.inventory.Count; i++)
                {
                    user.inventoryWindow.fxInventoryDGV.Rows.Add();
                    
                    user.inventoryWindow.fxInventoryDGV.Rows[i].Cells[1].Value = user.actor.inventory[i].GetName();
                }
            }
        }

        public static void ShowWindow()
        {
            user.inventoryWindow.Show();
            InitializeForm();
        }

        public static void BackBtn()
        {
            user.inventoryWindow.Hide();
            user.mainGameWindow.ShowWindow();
        }

        public static void ChosenItemDGV(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                IItem item = user.actor.inventory[e.RowIndex];
                user.actor.chosenItem = item;
                user.actor.numberOfChosenItem = e.RowIndex;

                user.inventoryWindow.fxNameOfItemLabel.Text = item.GetName();
                user.inventoryWindow.fxDescriptionOfItemText.Text = item.GetDescription();
                user.inventoryWindow.fxTtxText.Text = item.GetParamsString();
                user.inventoryWindow.fxUseBtn.Visible = true;
                user.inventoryWindow.fxDropBtn.Visible = true;
            }
            else
            {
                user.inventoryWindow.fxNameOfItemLabel.Text = "";
                user.inventoryWindow.fxDescriptionOfItemText.Text = "";
                user.inventoryWindow.fxTtxText.Text = "";
            }
        }

        public static void UseBtn()
        {
            List<Parameter> parameters = user.actor.chosenItem.GetParamsList();

            if (user.actor.chosenItem.GetType().Equals("Food"))
            {
                UseItem.UseFood(parameters);

                InitializeForm();
            }
        }

        public static void DropBtn()
        {
            user.actor.inventory.RemoveAt(user.actor.numberOfChosenItem);

            InitializeForm();
        }
    }
}
