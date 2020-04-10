using System;

namespace RpgAutoBattler
{
    public class FogHide : IPassiveSpell
    {
        public int TurnsLeft { get; set; }

        public int DodgeChance { get; set; }

        public void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == TriggerType.HitBySpell)
            {
                if (TurnsLeft > 0)
                {
                    Random rnd = new Random();
                    if (rnd.Next(0, 100) < DodgeChance)
                    {
                        Console.WriteLine($"{attacker.Name} {attacker.Surname} ({attacker.Class}) tries to attack!");
                        throw new ProtectException($"Miss! {victim.Name} {victim.Surname} ({victim.Class}) hides in the smoke screen and takes no damage!");
                    }
                }
            }

            if ((triggerType == TriggerType.EndTurn) && ((int)specValue[0] == 1))
            {
                TurnsLeft--;
            }

            if (triggerType == TriggerType.EndBattle)
            {
                TurnsLeft = 0;
            }
        }
    }
}