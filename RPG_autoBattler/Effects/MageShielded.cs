using System;

namespace RpgAutoBattler
{
    public class MageShielded : IPassiveSpell
    {
        public int TurnsLeft { get; set; }

        public void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == TriggerType.HitBySpell)
            {
                if (TurnsLeft > 0)
                {
                    Console.WriteLine($"{attacker.Name} {attacker.Surname} ({attacker.Class}) tries to attack!");
                    throw new ProtectException($"Wow! Magic Shield of {victim.Name} {victim.Surname} ({victim.Class}) absorbs all incoming damage! No damage taken!");
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
