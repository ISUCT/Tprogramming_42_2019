using System;

namespace RPG_autoBattler
{
    public class HammerStrike : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsPassive { get; set; }

        public int StunDuration { get; set; }

        public bool IsRanged { get; set; }

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
