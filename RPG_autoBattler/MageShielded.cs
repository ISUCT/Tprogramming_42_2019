using System;

namespace RPG_autoBattler
{
    public class MageShielded : IPassiveSpell
    {
        public int TurnsLeft { get; set; }

        void IPassiveSpell.Trigger(string triggerType, Char attacker, Char victim, float[] specValue)
        {
            if (triggerType == "HitBySpell")
            {
                if (TurnsLeft > 0)
                {
                    Console.WriteLine($"{attacker.Name} {attacker.Surname} ({attacker.Class}) tries to attack!");
                    throw new ProtectException($"Wow! Magic Shield of {victim.Name} {victim.Surname} ({victim.Class}) absorbs all incoming damage! No damage taken!");
                }
            }

            if ((triggerType == "TurnEnd") && ((int)specValue[0] == 1))
            {
                TurnsLeft--;
            }

            if (triggerType == "BattleEnd")
            {
                TurnsLeft = 0;
            }
        }
    }
}
