using HoboSimulator.Scripts.Windows.CreateActor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoboSimulator.Windows.Game.CreateActor
{
    public partial class CreateActorWindow : Form
    {
        public CreateActorWindow()
        {
            InitializeComponent();
        }

        //**БЛОК ОБНОВЛЕНИЯ ФОРМЫ**//

        private void InitializeForm(object sender, EventArgs e)
        {
            CreateActorWindowController.InitializeForm();
        }

        //**ОСНОВНЫЕ МЕТОДЫ**//

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            CreateActorWindowController.ClosedForm();
        }

        //**//

        //**ИНТЕРАКТИВНЫЕ ЭЛЕМЕНТЫ ФОРМЫ**//

        private void EndCreateBtn(object sender, EventArgs e)
        {
            CreateActorWindowController.EndCreateBtn();
        }

        //**//

        //**ЛОГИЧЕСКИЕ МЕТОДЫ ФОРМЫ**//
        private void HoboPresetChosenLB(object sender, EventArgs e)
        {

        }

        //**//
    }
}
