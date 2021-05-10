using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.System;
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
            if (e.RowIndex != null)
            {
                object item = user.actor.inventory[e.RowIndex];
                user.actor.chosenItem = item;
                user.actor.numberOfChosenItem = e.RowIndex;

                user.inventoryWindow.fxNameOfItemLabel.Text = GetInfoInventory.GetName(item);
                user.inventoryWindow.fxDescriptionOfItemText.Text = GetInfoInventory.GetDescription(item);
                user.inventoryWindow.fxTtxText.Text = GetInfoInventory.GetParamsString(item);
            }
        }

        public static void UseBtn()
        {
            List<Parameter> parameters = GetInfoInventory.GetParamsList(user.actor.chosenItem);

            if (GetInfoInventory.GetType(user.actor.chosenItem).Equals("Food"))
            {
                user.actor.hunger += parameters[0].value;
                user.actor.thirst += parameters[1].value;
                user.actor.stamina += parameters[2].value;
                user.actor.sleep += parameters[3].value;

                user.actor.inventory.RemoveAt(user.actor.numberOfChosenItem);

                InitializeForm();
            }
        }

        public static void DropBtn()
        {

        }
    }
}
