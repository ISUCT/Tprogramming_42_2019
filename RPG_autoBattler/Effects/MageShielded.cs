using System;

namespace RPG_autoBattler
{
    public class MageShielded : IPassiveSpell
    {
        public int TurnsLeft { get; set; }

        public void Trigger(string triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == "HitBySpell")
            {
                if (TurnsLeft > 0)
                {
                    Console.WriteLine($"{attacker.Name} {attacker.Surname} ({attacker.Class}) tries to attack!");
                    throw new ProtectException($"Wow! Magic Shield of {victim.Name} {victim.Surname} ({victim.Class}) absorbs all incoming damage! No damage taken!");
                }
            }

            if ((triggerType == "EndTurn") && ((int)specValue[0] == 1))
            {
                TurnsLeft--;
            }

            if (triggerType == "EndBattle")
            {
                TurnsLeft = 0;
            }
        }
    }
}
