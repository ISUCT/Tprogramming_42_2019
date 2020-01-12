using System;

namespace RPG_autoBattler
{
    public class HammerStrike : ISpell, IActiveSpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public int StunDuration { get; set; }

        public bool IsRanged { get; set; }

        public void Cast(Char caster, Char victim)
        {
            Logger.StunM(victim, StunDuration);
            victim.TakeDamage(caster, caster.Agility);
            victim.StunTimer += StunDuration;
        }
    }
}
