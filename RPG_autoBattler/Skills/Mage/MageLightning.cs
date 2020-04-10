using System;

namespace RpgAutoBattler
{
    public class MageLightning : ISpell
    {
        public string Name { get; set; } = "Lightning Strike";

        public int Lvl { get; set; }

        public float DamageMultiplier { get; set; }

        public bool IsPassive { get; set; } = false;

        public bool IsRanged { get; set; } = true;

        public void Cast(Character caster, Character victim)
        {
            victim.TakeDamage(caster, caster.Intelligence * DamageMultiplier);
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
