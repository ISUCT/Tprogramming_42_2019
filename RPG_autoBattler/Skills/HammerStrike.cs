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

        public void Cast(Char caster, Char victim)
        {
            Logger.StunM(victim, StunDuration);
            victim.TakeDamage(caster, caster.Agility);
            victim.StunTimer += StunDuration;
        }

        public void Trigger(string s, Char a, Char b, float[] f)
        {
        }
    }
}
