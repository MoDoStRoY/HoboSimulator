using HoboSimulator.Config.Objects.Characters.NPC;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.Fight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame
{
    class FightWindowController
    {
        static User user = Program.user;

        public static INPC NPC;

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        public static void InitializeForm()
        {
            UpdateActionVariables();

            user.fightWindow.fxActorIconPB.Image = user.actor.icon;
            user.fightWindow.fxActorNameLabel.Text = user.actor.name;
            user.fightWindow.fxActorGroupLabel.Text = user.actor.group;

            user.mainGameWindow.fxResumeFightBtn.Enabled = true;
            user.fightWindow.fxAttackBtn.Enabled = true;
            user.fightWindow.fxDodgeBtn.Enabled = true;
            user.fightWindow.fxDefenceBtn.Enabled = true;
            user.fightWindow.fxEscapeBtn.Enabled = true;
            user.fightWindow.fxLootNPCBtn.Visible = false;
            user.fightWindow.fxResultOfActionText.Clear();

            user.fightWindow.fxActorParamsDGV.Rows.Clear();
            for (int i = 0; i < user.actor.skills.Count; i++)
            {
                user.fightWindow.fxActorParamsDGV.Rows.Add();

                user.fightWindow.fxActorParamsDGV.Rows[i].Cells[0].Value = user.actor.skills[i].name;
                user.fightWindow.fxActorParamsDGV.Rows[i].Cells[1].Value = user.actor.skills[i].value;
            }
        }

        public static void UpdateNPC()
        {
            user.fightWindow.fxNPCIconPB.Image = NPC.GetIcon();
            user.fightWindow.fxNPCNameLabel.Text = NPC.GetName();
            user.fightWindow.fxNPCGroupLabel.Text = NPC.GetGroup();
            user.fightWindow.fxNPCHealthPB.Value = NPC.GetHealth();
            user.fightWindow.fxNPCHealthLabel.Text = NPC.GetHealth().ToString();
            user.fightWindow.fxNPCStaminaPB.Value = NPC.GetStamina();
            user.fightWindow.fxNPCStaminaLabel.Text = NPC.GetStamina().ToString();

            user.fightWindow.fxNPCParamsDGV.Rows.Clear();
            for (int i = 0; i < NPC.GetSkills().Count; i++)
            {
                user.fightWindow.fxNPCParamsDGV.Rows.Add();

                user.fightWindow.fxNPCParamsDGV.Rows[i].Cells[0].Value = NPC.GetSkills()[i].name;
                user.fightWindow.fxNPCParamsDGV.Rows[i].Cells[1].Value = NPC.GetSkills()[i].value;
            }
        }

        public static void UpdateActionVariables()
        {
            InitializeParamsBlock.InitializeParamsBlockFight();
        }

        //**//

        //**ОСНОВЫЕ МЕТОДЫ**//

        public static void ShowWindow(INPC NPCIn) // Метод переключения на эту форму
        {
            user.fightWindow.Show();
            NPC = NPCIn;
            InitializeForm();
            UpdateNPC();

            user.actor.inFight = true;
        }

        public static void RShowWindow() // Метод возобновления показа формы
        {
            user.fightWindow.Show();
            InitializeForm();
        }

        public static void BackBtn() // Кнопка "Назад"
        {
            user.fightWindow.Hide();
            user.actionWindow.ShowWindow();
        }

        public static void ClosedForm() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        //*ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        public static void AttackBtn()
        {
            FightMain.Fighting(NPC, "Attack", true);
            UpdateNPC();
            UpdateActionVariables();
        }

        public static void LootNpcBtn()
        {
            user.fightWindow.Hide();
            user.lootWindow.ShowWindow(NPC.GetInventory());
        }

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//

        // Пока не используется

        //**//
    }
}
