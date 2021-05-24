using HoboSimulator.Config.Objects.Misc.Items;
using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame.Trade
{
    class TradeWindowController
    {
        static User user = Program.user;

        static double summaryCost = 0;
        static double summaryWeight = 0;

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public static void InitializeForm()
        {
            UpdateTradeVariables();
            UpdateActionVariables();
        }

        public static void UpdateTradeVariables()
        {
            user.tradeWindow.fxAssortmentDGV.Rows.Clear();
            user.tradeWindow.fxChosenGoodsDGV.Rows.Clear();

            summaryCost = 0;
            summaryWeight = 0;

            if (user.actor.zone.GetStoreAssortment().Count > 0)
            {
                for (int i = 0; i < user.actor.zone.GetStoreAssortment().Count; i++)
                {
                    user.tradeWindow.fxAssortmentDGV.Rows.Add();
                    user.tradeWindow.fxAssortmentDGV.Rows[i].Cells[0].Value = user.actor.zone.GetStoreAssortment()[i].GetName();
                    user.tradeWindow.fxAssortmentDGV.Rows[i].Cells[1].Value = user.actor.zone.GetStoreAssortment()[i].GetCost() + " руб.";
                    user.tradeWindow.fxAssortmentDGV.Rows[i].Cells[2].Value = user.actor.zone.GetStoreAssortment()[i].GetWeight() + " кг";
                }
            }

            if (user.actor.zone.GetChosenGoods().Count > 0)
            {
                for (int i = 0; i < user.actor.zone.GetChosenGoods().Count; i++)
                {
                    user.tradeWindow.fxChosenGoodsDGV.Rows.Add();
                    user.tradeWindow.fxChosenGoodsDGV.Rows[i].Cells[0].Value = user.actor.zone.GetChosenGoods()[i].GetName();
                    user.tradeWindow.fxChosenGoodsDGV.Rows[i].Cells[1].Value = user.actor.zone.GetChosenGoods()[i].GetCost() + " руб.";
                    user.tradeWindow.fxChosenGoodsDGV.Rows[i].Cells[2].Value = user.actor.zone.GetChosenGoods()[i].GetWeight() + " кг";

                    summaryCost += user.actor.zone.GetChosenGoods()[i].GetCost();
                    summaryWeight += user.actor.zone.GetChosenGoods()[i].GetWeight();
                }

                user.tradeWindow.fxSummaryCostLabel.Text = summaryCost + " руб.";
                user.tradeWindow.fxSummaryWeightLabel.Text = summaryWeight + " кг";
            }
        }

        public static void UpdateActionVariables()
        {
            InitializeParamsBlock.InitializeParamsBlockTrade();
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public static void ShowWindow() // Метод показа формы
        {
            user.tradeWindow.Show();
            InitializeForm();
        }

        public static void BackBtn() // Кнопка "Назад"
        {
            user.tradeWindow.Hide();
            user.actionWindow.ShowWindow();
        }

        public static void ClosedForm() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        public static void BuyBtn() // Кнопка покупки
        {
            if (user.actor.money >= summaryCost)
            {
                user.actor.inventory.AddRange(user.actor.zone.GetChosenGoods());
                user.actor.money -= summaryCost;

                user.actor.zone.SetChosenGoods(new List<IItem>());

                UpdateTradeVariables();
            }
        }

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        public static void ChoseGoodDGV(DataGridViewCellEventArgs e) // Добавление товара в корзину
        {
            if (e.RowIndex != -1)
            {
                user.actor.zone.AddChosenGoods(e.RowIndex);
                UpdateTradeVariables();
            }
        }

        public static void DeleteGoodDGV(DataGridViewCellEventArgs e) // Удаление товара из корзины
        {
            if (e.RowIndex != -1)
            {
                user.actor.zone.DeleteChosenGoods(e.RowIndex);
                UpdateTradeVariables();
            }
        }

        public static void InfoGoodAssortmentDGV(DataGridViewCellEventArgs e) // Подгрузка данных о товаре из ассортимента
        {
            if (e.RowIndex != -1)
            {
                IItem item = user.actor.zone.GetStoreAssortment()[e.RowIndex];
                user.actor.chosenItem = item;
                user.actor.numberOfChosenItem = e.RowIndex;

                user.tradeWindow.fxNameOfItemLabel.Text = item.GetName();
                user.tradeWindow.fxDescriptionOfItemText.Text = item.GetDescription();
                user.tradeWindow.fxTtxText.Text = item.GetParamsString();
            }
            else
            {
                user.tradeWindow.fxNameOfItemLabel.Text = "";
                user.tradeWindow.fxDescriptionOfItemText.Text = "";
                user.tradeWindow.fxTtxText.Text = "";
            }
        }

        public static void InfoGoodChosenDGV(DataGridViewCellEventArgs e) // Подгрузка данных о товаре из корзины
        {
            if (e.RowIndex != -1)
            {
                IItem item = user.actor.zone.GetChosenGoods()[e.RowIndex];
                user.actor.chosenItem = item;
                user.actor.numberOfChosenItem = e.RowIndex;

                user.tradeWindow.fxNameOfItemLabel.Text = item.GetName();
                user.tradeWindow.fxDescriptionOfItemText.Text = item.GetDescription();
                user.tradeWindow.fxTtxText.Text = item.GetParamsString();
            }
            else
            {
                user.tradeWindow.fxNameOfItemLabel.Text = "";
                user.tradeWindow.fxDescriptionOfItemText.Text = "";
                user.tradeWindow.fxTtxText.Text = "";
            }
        }

        //**//
    }
}
