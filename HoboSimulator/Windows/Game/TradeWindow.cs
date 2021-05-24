using HoboSimulator.Scripts.Windows.MainGame.Trade;
using System;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game
{
    public partial class TradeWindow : Form
    {
        public TradeWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**///

        private void InitializeForm(object sender, EventArgs e)
        {
            TradeWindowController.InitializeForm();
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public void ShowWindow() // Метод показа формы
        {
            TradeWindowController.ShowWindow();
        }

        private void BackBtn(object sender, EventArgs e) // Кнопка "Назад"
        {
            TradeWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e) // Закрытие формы
        {
            TradeWindowController.ClosedForm();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        private void BuyBtn(object sender, EventArgs e) // Кнопка покупки
        {
            TradeWindowController.BuyBtn();
        }

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        private void ChoseGoodDGV(object sender, DataGridViewCellEventArgs e) // Добавление товара в корзину
        {
            TradeWindowController.ChoseGoodDGV(e);
        }

        private void DeleteGoodDGV(object sender, DataGridViewCellEventArgs e) // Удаление товара из корзины
        {
            TradeWindowController.DeleteGoodDGV(e);
        }

        private void InfoGoodAssortmentDGV(object sender, DataGridViewCellEventArgs e) // Подгрузка данных о товаре из ассортимента
        {
            TradeWindowController.InfoGoodAssortmentDGV(e);
        }

        private void InfoGoodChosenDGV(object sender, DataGridViewCellEventArgs e) // Подгрузка данных о товаре из корзины
        {
            TradeWindowController.InfoGoodChosenDGV(e);
        }

        //**//
    }
}
