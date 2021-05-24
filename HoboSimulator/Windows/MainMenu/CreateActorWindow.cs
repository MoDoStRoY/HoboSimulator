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

        private void InitializeForm(object sender, EventArgs e)
        {
            CreateActorWindowController.InitializeForm();
        }

        private void EndCreateBtn(object sender, EventArgs e)
        {
            CreateActorWindowController.EndCreateBtn();
        }

        private void HoboPresetChosenLB(object sender, EventArgs e)
        {

        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            CreateActorWindowController.ClosedForm();
        }
    }
}
