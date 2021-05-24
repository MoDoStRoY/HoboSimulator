using HoboSimulator.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame
{
    class MainGameWindowController
    {
        static User user = Program.user;

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public static void InitializeForm()
        {
            user.mainGameWindow.fxActorIconPB.Image = user.actor.icon;
            user.mainGameWindow.fxLocationLabel.Text = user.actor.location.GetName() + ", " + user.actor.zone.GetName();
            user.mainGameWindow.fxNameOfActor.Text = user.actor.name;
            user.mainGameWindow.fxAgeOfActor.Text = user.actor.age.ToString();
            user.mainGameWindow.fxBiography.Text = user.actor.biography;
            user.mainGameWindow.fxSkillPointsLabel.Text = user.actor.skillPoints.ToString();

            user.mainGameWindow.fxSkillsDGV.Rows.Clear();
            for (int i = 0; i < user.actor.skills.Count; i++)
            { 
                user.mainGameWindow.fxSkillsDGV.Rows.Add();
                user.mainGameWindow.fxSkillsDGV.Rows[i].Cells[0].Value = user.actor.skills[i].name;
                user.mainGameWindow.fxSkillsDGV.Rows[i].Cells[1].Value = user.actor.skills[i].value;
            }

            InitializeParamsBlock.InitializeParamsBlockMainGame();
        }

        //**//

        //**ОСНОВНЫЕ МЕТОДЫ**//

        public static void ShowWindow() // Метод показа формы
        {
            InitializeForm();
            user.mainGameWindow.Show();
        }

        public static void MenuBtn() // Кнопка "Меню"
        {
            user.mainGameWindow.Hide();
            user.mainMenu.ShowWindow();
        }

        public static void ClosedForm() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        public static void ActionBtn() // Кнопка перехода в форму действий
        {
            user.mainGameWindow.Hide();
            user.actionWindow.ShowWindow();
        }

        public static void MovingBtn() // Кнопка перехода в форму перемещений
        {
            user.mainGameWindow.Hide();
            user.moveWindow.ShowWindow();
        }

        public static void InventoryBtn() // Кнопка перехода в форму инвентаря
        {
            user.mainGameWindow.Hide();
            user.inventoryWindow.ShowWindow();
        }

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        public static void SkillUpCell(DataGridViewCellEventArgs e)
        {
            if (user.actor.skillPoints > 0)
            {
                user.actor.skills[e.RowIndex].value++;
                user.mainGameWindow.fxSkillsDGV.Rows[e.RowIndex].Cells[1].Value = user.actor.skills[e.RowIndex].value.ToString();
                user.actor.skillPoints--;
                user.mainGameWindow.fxSkillPointsLabel.Text = user.actor.skillPoints.ToString();
            }    
        }

        //**//
    }
}
