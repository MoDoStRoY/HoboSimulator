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

        public static void InitializeForm()
        {
            user.mainGameWindow.fxNameOfActor.Text = user.actor.name;
            user.mainGameWindow.fxAgeOfActor.Text = user.actor.age.ToString();
            user.mainGameWindow.fxBiography.Text = user.actor.biography;
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
            user.mainGameWindow.fxSkillPointsLabel.Text = user.actor.skillPoints.ToString();

            user.mainGameWindow.fxSkillsDGV.Rows.Clear();
            for (int i = 0; i < user.actor.skills.Count; i++)
            { 
                user.mainGameWindow.fxSkillsDGV.Rows.Add();
                user.mainGameWindow.fxSkillsDGV.Rows[i].Cells[0].Value = user.actor.skills[i].name;
                user.mainGameWindow.fxSkillsDGV.Rows[i].Cells[1].Value = user.actor.skills[i].value;
            }
        }

        public static void ShowWindow()
        {
            InitializeForm();
            user.mainGameWindow.Show();
        }

        public static void ActionBtn()
        {
            user.mainGameWindow.Hide();
            user.actionWindow.ShowWindow();
        }

        public static void MovingBtn()
        {

        }

        public static void SkillUpCell(DataGridViewCellEventArgs e)
        {
            if (user.actor.skillPoints > 0)
            {
                user.actor.skills[e.RowIndex].value++;
                user.mainGameWindow.fxSkillsDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = user.actor.skills[e.RowIndex].value.ToString();
                user.actor.skillPoints--;
                user.mainGameWindow.fxSkillPointsLabel.Text = user.actor.skillPoints.ToString();
            }    
        }

        public static void MenuBtn()
        {
            user.mainGameWindow.Hide();
            user.mainMenu.Show();
        }

        public static void InventoryBtn()
        {
            user.mainGameWindow.Hide();
            user.inventoryWindow.ShowWindow();
        }
    }
}
