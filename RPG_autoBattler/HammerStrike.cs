using System;

namespace RPG_autoBattler
{
    public class HammerStrike : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        public float Damage { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            victim.TakeDamage(caster, Damage);
        }
    }
}
