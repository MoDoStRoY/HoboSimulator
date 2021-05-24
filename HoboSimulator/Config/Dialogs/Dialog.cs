using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Config.Dialogs
{
    public class Dialog
    {
        public String phrase_actor;
        public String phrase_NPC;
        public List<Dialog> dialog_tree;

        public Dialog (String phrase_actor, String phrase_NPC, List<Dialog> dialog_tree)
        {
            this.phrase_actor = phrase_actor;
            this.phrase_NPC = phrase_NPC;
            this.dialog_tree = dialog_tree;
        }
    }
}
