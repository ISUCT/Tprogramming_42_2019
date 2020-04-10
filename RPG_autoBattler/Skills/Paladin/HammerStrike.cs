using System;

namespace RpgAutoBattler
{
    public class HammerStrike : ISpell
    {
        public string Name { get; set; } = "Hammer Strike";

        public int Lvl { get; set; }

        public bool IsPassive { get; set; } = false;

        public int StunDuration { get; set; } = 1;

        public bool IsRanged { get; set; } = false;

        public void Cast(Character caster, Character victim)
        {
            Logger.StunM(victim, StunDuration);
            victim.TakeDamage(caster, caster.Agility);
            victim.StunTimer += StunDuration;
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
