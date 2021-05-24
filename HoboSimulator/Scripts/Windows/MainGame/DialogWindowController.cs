using HoboSimulator.Config.Objects.Characters.NPC;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Config.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Scripts.Windows.MainGame
{
    class DialogWindowController
    {
        static User user = Program.user;

        static List<Dialog> dialog_tree;
        public static INPC NPC;

        public static void InitializeForm()
        {
            UpdateActionVariables();

            user.dialogWindow.fxActorIconPB.Image = user.actor.icon;
            user.dialogWindow.fxActorNameLabel.Text = user.actor.name;
            user.dialogWindow.fxActorGroupLabel.Text = user.actor.group;
        }

        public static void UpdateNPC()
        {
            user.dialogWindow.fxNPCIconPB.Image = NPC.GetIcon();
            user.dialogWindow.fxNPCNameLabel.Text = NPC.GetName();
            user.dialogWindow.fxNPCGroupLabel.Text = NPC.GetGroup();

            dialog_tree = NPC.GetDialogs();
            UpdateDialog();
        }

        public static void UpdateDialog()
        {
            for (int i = 0; i < dialog_tree.Count; i++)
            {
                user.dialogWindow.fxDialogDGW.Rows.Add();

                user.dialogWindow.fxDialogDGW.Rows[i].Cells[0].Value = dialog_tree[i].phrase_actor;
            }
        }

        public static void UpdateActionVariables()
        {
            user.dialogWindow.fxMoneyLabel.Text = user.actor.money.ToString();
            user.dialogWindow.fxCurrentTimeLabel.Text = user.world.dateTime.ToString();
            user.dialogWindow.fxHealthPB.Value = user.actor.health;
            user.dialogWindow.fxHealthLabel.Text = user.actor.health.ToString();
            user.dialogWindow.fxThirstPB.Value = user.actor.thirst;
            user.dialogWindow.fxThirstLabel.Text = user.actor.thirst.ToString();
            user.dialogWindow.fxHungerPB.Value = user.actor.hunger;
            user.dialogWindow.fxHungerLabel.Text = user.actor.hunger.ToString();
            user.dialogWindow.fxStaminaPB.Value = user.actor.stamina;
            user.dialogWindow.fxStaminaLabel.Text = user.actor.stamina.ToString();
            user.dialogWindow.fxSleepPB.Value = user.actor.sleep;
            user.dialogWindow.fxSleepLabel.Text = user.actor.sleep.ToString();
        }

        public static void ShowWindow(INPC NPCIn)
        {
            user.dialogWindow.Show();
            NPC = NPCIn;
            InitializeForm();
            UpdateNPC();
        }

        public static void BackBtn()
        {
            user.dialogWindow.Hide();
            user.actionWindow.ShowWindow();
        }

        public static void ChoseDialogVariantDGV(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                user.dialogWindow.fxDialogDGW.Rows.Clear();

                user.dialogWindow.fxNPCAnswersText.Text += user.actor.name + ":\n" + dialog_tree[e.RowIndex].phrase_actor + "\n\n" +
                    NPC.GetName() + ":\n" + dialog_tree[e.RowIndex].phrase_NPC + "\n\n";

                dialog_tree = dialog_tree[e.RowIndex].dialog_tree;

                for (int i = 0; i < dialog_tree.Count; i++)
                {
                    user.dialogWindow.fxDialogDGW.Rows.Add();

                    user.dialogWindow.fxDialogDGW.Rows[i].Cells[0].Value = dialog_tree[i].phrase_actor;
                }
            }    
        }
    }
}
