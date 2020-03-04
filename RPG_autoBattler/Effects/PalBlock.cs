using System;

namespace RPG_autoBattler
{
    public class PalBlock : IPassiveSpell
    {
        public int TurnsLeft { get; set; }

        public float DamageBlockPercent { get; set; }

        public void Trigger(string triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == "TakeDamage")
            {
                victim.CurHP -= specValue[0] * (DamageBlockPercent / 100);
                throw new ProtectException($"{victim.Name} {victim.Surname} ({victim.Class}) takes only {specValue[0] * (DamageBlockPercent / 100)} damage! {victim.CurHP} HP left!");
            }
        }
    }
}
