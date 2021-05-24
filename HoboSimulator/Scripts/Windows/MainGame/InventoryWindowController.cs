using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Inventory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame.Inventory
{
    class InventoryWindowController
    {
        static User user = Program.user;

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public static void InitializeForm()
        {
            double weight = 0;
            for (int i = 0; i < user.actor.inventory.Count; i++)
                weight += user.actor.inventory[i].GetWeight(); 

            user.inventoryWindow.fxWeightLabel.Text = weight + " кг";
            user.inventoryWindow.fxMaxWeightLabel.Text = user.actor.maxWeight + " кг";
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

            InitializeParamsBlock.InitializeParamsBlockInventory();
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public static void ShowWindow() // Метод показа формы
        {
            user.inventoryWindow.Show();
            InitializeForm();
        }

        public static void BackBtn() // Кнопка "Назад"
        {
            user.inventoryWindow.Hide();
            user.mainGameWindow.ShowWindow();
        }

        public static void ClosedForm() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        public static void UseBtn() // Кнопка "Использовать"
        {
            List<Parameter> parameters = user.actor.chosenItem.GetParamsList();

            if (user.actor.chosenItem.GetType().Equals("Food"))
            {
                UseItem.UseFood(parameters);

                InitializeForm();
            }
        }

        public static void DropBtn() // Кнопка "Выбросить"
        {
            user.actor.inventory.RemoveAt(user.actor.numberOfChosenItem);

            InitializeForm();
        }

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        public static void ChosenItemDGV(DataGridViewCellEventArgs e) //Выбор предмета
        {
            if (e.RowIndex != -1)
            {
                IItem item = user.actor.inventory[e.RowIndex];
                user.actor.chosenItem = item;
                user.actor.numberOfChosenItem = e.RowIndex;

                user.inventoryWindow.fxNameOfItemLabel.Text = item.GetName();
                user.inventoryWindow.fxDescriptionOfItemText.Text = item.GetDescription();
                user.inventoryWindow.fxTtxText.Text = item.GetParamsString();

                if (item.GetUsable()) user.inventoryWindow.fxUseBtn.Visible = true;
                else user.inventoryWindow.fxUseBtn.Visible = false;

                user.inventoryWindow.fxDropBtn.Visible = true;
            }
            else
            {
                user.inventoryWindow.fxNameOfItemLabel.Text = "";
                user.inventoryWindow.fxDescriptionOfItemText.Text = "";
                user.inventoryWindow.fxTtxText.Text = "";
            }
        }

        //**//
    }
}
