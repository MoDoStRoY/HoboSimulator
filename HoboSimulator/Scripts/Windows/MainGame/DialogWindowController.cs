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

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

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
            InitializeParamsBlock.InitializeParamsBlockDialog();
        }

        //**//

        //**ОСНОВЫЕ МЕТОДЫ**//

        public static void ShowWindow(INPC NPCIn) // Метод переключения на эту форму
        {
            user.dialogWindow.Show();
            NPC = NPCIn;
            InitializeForm();
            UpdateNPC();
        }

        public static void BackBtn() // Кнопка "Назад"
        {
            user.dialogWindow.Hide();
            user.actionWindow.ShowWindow();
        }

        public static void ClosedForm() // Закрытие формы
        {
            Application.Exit();
        }

        //**//

        public static void ChoseDialogVariantDGV(DataGridViewCellEventArgs e) // Выбор варианта фразы в диалоге
        {
            if (e.RowIndex != -1)
            {
                user.dialogWindow.fxDialogDGW.Rows.Clear();

                user.dialogWindow.fxNPCAnswersText.AppendText(user.actor.name + ":\n" + dialog_tree[e.RowIndex].phrase_actor + "\n\n" +
                    NPC.GetName() + ":\n" + dialog_tree[e.RowIndex].phrase_NPC + "\n\n");

                dialog_tree = dialog_tree[e.RowIndex].dialog_tree;

                if (dialog_tree != null)
                {
                    for (int i = 0; i < dialog_tree.Count; i++)
                    {
                        user.dialogWindow.fxDialogDGW.Rows.Add();

                        user.dialogWindow.fxDialogDGW.Rows[i].Cells[0].Value = dialog_tree[i].phrase_actor;
                    }
                }
                else
                {
                    dialog_tree = NPC.GetDialogs();
                    UpdateDialog();
                }
            }
            user.dialogWindow.fxNPCAnswersText.ScrollToCaret();
        }
    }
}
