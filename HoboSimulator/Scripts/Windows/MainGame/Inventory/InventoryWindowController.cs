using HoboSimulator.Config.Objects.Actor;
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
            user.inventoryWindow.fxInventoryDGV.Rows.Clear();
            user.inventoryWindow.fxNameOfItemLabel.Text = "";
            user.inventoryWindow.fxDescriptionOfItemText.Text = "";
            user.inventoryWindow.fxTtxText.Text = "";

            if (user.actor.inventory.Count > 0)
            {
                for (int i = 0; i < user.actor.inventory.Count; i++)
                {
                    user.inventoryWindow.fxInventoryDGV.Rows.Add();
                    
                    user.inventoryWindow.fxInventoryDGV.Rows[i].Cells[1].Value = GetInfoInventory.GetName(user.actor.inventory[i]);
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
                object item = user.actor.inventory[e.RowIndex];
                user.actor.chosenItem = item;
                user.actor.numberOfChosenItem = e.RowIndex;

                user.inventoryWindow.fxNameOfItemLabel.Text = GetInfoInventory.GetName(item);
                user.inventoryWindow.fxDescriptionOfItemText.Text = GetInfoInventory.GetDescription(item);
                user.inventoryWindow.fxTtxText.Text = GetInfoInventory.GetParamsString(item);
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
            List<Parameter> parameters = GetInfoInventory.GetParamsList(user.actor.chosenItem);

            if (GetInfoInventory.GetType(user.actor.chosenItem).Equals("Food"))
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
