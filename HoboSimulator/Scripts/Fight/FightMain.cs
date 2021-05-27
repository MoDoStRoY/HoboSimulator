using HoboSimulator.Config.Objects.Actor;
using HoboSimulator.Config.Objects.Characters.NPC;
using HoboSimulator.Config.Objects.System;
using HoboSimulator.Scripts.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoboSimulator.Scripts.Fight
{
    public class FightMain
    {
        static INPC NPC;
        static Actor actor = Program.user.actor;
        static User user = Program.user;
        static Random random = new Random();
        static bool actionFromActor;

        public static void Fighting(INPC NPCIn, String action, bool actionFromActorIn)
        {
            NPC = NPCIn;
            actionFromActor = actionFromActorIn;

            switch (action)
            {
                case "Attack":
                    FightAttack();
                    break;
                case "Dodge":
                    FightDodge();
                    break;
                case "Defence":
                    FightDefence();
                    break;
                case "Escape":
                    FightEscape();
                    break;
            }
        }

        private static void FightAttack()
        {
            if (ChanceToHit())
            {
                if (actionFromActor)
                {
                    NPC.EditHealth((actor.skills[0].value * -5));
                    actor.Stamina -= (50 - actor.skills[2].value * 4);

                    user.fightWindow.fxResultOfActionText.AppendText("\n\n" + actor.name + " нанёс удар " + NPC.GetName() + ".\n" + 
                        NPC.GetName() + " получен урон: " + actor.skills[0].value * 5 + ".");
                }
                else
                {
                    actor.Health -= NPC.GetSkills()[0].value * 5;
                    NPC.EditStamina(-50 - NPC.GetSkills()[2].value * -4);

                    user.fightWindow.fxResultOfActionText.AppendText("\n\n" + NPC.GetName() + " нанёс удар " + actor.name + ".\n" +
                        actor.name + " получен урон: " + NPC.GetSkills()[0].value * 5 + ".");
                }
            }
            else
            {
                if (actionFromActor)
                {
                    user.fightWindow.fxResultOfActionText.AppendText("\n\n" + actor.name + " попытался нанести удар по " + NPC.GetName()
                    + " но промахнулся.");

                    actor.Stamina -= (50 - actor.skills[2].value * 4);
                }    
                else
                {
                    user.fightWindow.fxResultOfActionText.AppendText("\n\n" + NPC.GetName() + " попытался нанести удар по " + actor.name
                    + " но промахнулся.");
                    NPC.EditStamina(-50 - NPC.GetSkills()[2].value * -4);
                }    
            }
            user.fightWindow.fxResultOfActionText.ScrollToCaret();

            TimeFlow.AddMinutes(1);
        }

        public static bool ChanceToHit()
        {
            int agility;
            int luck;

            if (actionFromActor)
            {
                agility = actor.skills[1].value - NPC.GetSkills()[1].value;
                luck = actor.skills[5].value - NPC.GetSkills()[5].value;
            }
            else
            {
                agility = NPC.GetSkills()[1].value - actor.skills[1].value;
                luck = NPC.GetSkills()[5].value - actor.skills[5].value;
            }

            if (random.Next(agility + luck / 3, 10) >= 4)
                return true;
            else
                return false;
        }

        private static void FightDodge()
        {

        }

        private static void FightDefence()
        {

        }

        private static void FightEscape()
        {

        }
    }
}
