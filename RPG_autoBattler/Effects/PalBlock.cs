using System;

namespace RpgAutoBattler
{
    public class PalBlock : IPassiveSpell
    {
        public int TurnsLeft { get; set; }

        public float DamageBlockPercent { get; set; }

        public void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == TriggerType.TakeDamage)
            {
                victim.CurHP -= specValue[0] * (DamageBlockPercent / 100);
                throw new ProtectException($"{victim.Name} {victim.Surname} ({victim.Class}) takes only {specValue[0] * (DamageBlockPercent / 100)} damage! {victim.CurHP} HP left!");
            }
        }
    }
}
