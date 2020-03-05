using System;

namespace RPG_autoBattler
{
    public class NinjaBleedEffect : IPassiveSpell
    {
        public int TurnsLeft { get; set; }

        public float DamagePercent { get; set; }

        public void Trigger(string triggerType, Character attacker, Character victim, float[] specValue)
        {
            if ((triggerType == "EndTurn") && (specValue[0] == 0) && (TurnsLeft > 0))
            {
                Console.WriteLine($"{attacker} is bleeding! {TurnsLeft} turns left!");
                attacker.CurHP -= DamagePercent * attacker.MaxHP;
                Logger.TakeDamageM(attacker, DamagePercent * attacker.MaxHP);
                TurnsLeft--;
            }
        }
    }
}
