using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame
{
    class LootWindowController
    {

        static User user = Program.user;
        static List<IItem> loot;
        static double summaryWeight;

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public static void InitializeForm()
        {
            InitializeParamsBlock.InitializeParamsBlockInventory();
        }

        public static void UpdateLoot()
        {
            user.lootWindow.fxLootDGV.Rows.Clear();
            user.lootWindow.fxInventoryDGV.Rows.Clear();

            summaryWeight = 0;

            if (loot.Count > 0)
            {
                for (int i = 0; i < loot.Count; i++)
                {
                    user.lootWindow.fxLootDGV.Rows.Add();
                    user.lootWindow.fxLootDGV.Rows[i].Cells[0].Value = loot[i].GetName();
                    user.lootWindow.fxLootDGV.Rows[i].Cells[1].Value = loot[i].GetCost() + " руб.";
                    user.lootWindow.fxLootDGV.Rows[i].Cells[2].Value = loot[i].GetWeight() + " кг";
                }
            }

            if (user.actor.inventory.Count > 0)
            {
                for (int i = 0; i < user.actor.inventory.Count; i++)
                {
                    user.lootWindow.fxInventoryDGV.Rows.Add();
                    user.lootWindow.fxInventoryDGV.Rows[i].Cells[0].Value = user.actor.inventory[i].GetName();
                    user.lootWindow.fxInventoryDGV.Rows[i].Cells[1].Value = user.actor.inventory[i].GetCost() + " руб.";
                    user.lootWindow.fxInventoryDGV.Rows[i].Cells[2].Value = user.actor.inventory[i].GetWeight() + " кг";

                    summaryWeight += user.actor.inventory[i].GetWeight();
                }

                user.lootWindow.fxWeightLabel.Text = summaryWeight + " кг";
                user.lootWindow.fxMaxWeightLabel.Text = user.actor.maxWeight.ToString();
            }
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public static void ShowWindow(List<IItem> lootIn) // Метод показа формы
        {
            user.lootWindow.Show();
            loot = lootIn;
            InitializeForm();
            UpdateLoot();
        }

        public static void BackBtn() // Кнопка "Назад"
        {
            user.lootWindow.Hide();
            user.fightWindow.RShowWindow();
        }

        public static void ClosedForm() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//



        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        public static void InfoItemFromLootDGV(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                IItem item = loot[e.RowIndex];
                user.actor.chosenItem = item;
                user.actor.numberOfChosenItem = e.RowIndex;

                user.lootWindow.fxNameOfItemLabel.Text = item.GetName();
                user.lootWindow.fxDescriptionOfItemText.Text = item.GetDescription();
                user.lootWindow.fxTtxText.Text = item.GetParamsString();
            }
            else
            {
                user.lootWindow.fxNameOfItemLabel.Text = "";
                user.lootWindow.fxDescriptionOfItemText.Text = "";
                user.lootWindow.fxTtxText.Text = "";
            }
        }

        public static void ChoseItemFromLootDGV(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                user.actor.inventory.Add(loot[e.RowIndex]);
                loot.RemoveAt(e.RowIndex);
                UpdateLoot();
            }
        }

        public static void InfoItemFromInventoryDGV(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                IItem item = user.actor.inventory[e.RowIndex];
                user.actor.chosenItem = item;
                user.actor.numberOfChosenItem = e.RowIndex;

                user.lootWindow.fxNameOfItemLabel.Text = item.GetName();
                user.lootWindow.fxDescriptionOfItemText.Text = item.GetDescription();
                user.lootWindow.fxTtxText.Text = item.GetParamsString();
            }
            else
            {
                user.lootWindow.fxNameOfItemLabel.Text = "";
                user.lootWindow.fxDescriptionOfItemText.Text = "";
                user.lootWindow.fxTtxText.Text = "";
            }
        }

        public static void DeleteItemFromInventoryDGV(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                loot.Add(user.actor.inventory[e.RowIndex]);
                user.actor.inventory.RemoveAt(e.RowIndex);
                UpdateLoot();
            }
        }


        //**//

    }
}
