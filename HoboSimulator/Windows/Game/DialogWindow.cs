using HoboSimulator.Config.Objects.Characters.NPC;
using HoboSimulator.Scripts.Windows.MainGame;
using System;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game
{
    public partial class DialogWindow : Form
    {
        public DialogWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//
        //В данном случае не используется, т.к. форма открывается через ShowWindow, вызывающий инициализацию//
        private void InitializeForm(object sender, EventArgs e)
        {
            DialogWindowController.InitializeForm();
        }

        //**//

        //**ОСНОВЫЕ МЕТОДЫ**//

        public void ShowWindow(INPC NPC) // Метод показа этой формы
        {
            DialogWindowController.ShowWindow(NPC);
        }

        private void BackBtn(object sender, EventArgs e) // Кнопка "Назад"
        {
            DialogWindowController.BackBtn();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e) // Закрытие формы
        {
            DialogWindowController.ClosedForm();
        }

        //**//

        private void ChoseDialogVariantDGV(object sender, DataGridViewCellEventArgs e) // Выбор варианта фразы в диалоге
        {
            DialogWindowController.ChoseDialogVariantDGV(e);
        }
    }
}
