using System;

namespace RPG_autoBattler
{
    public class BaseAttack : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            victim.TakeDamage(caster, caster.Agility);
        }
    }
}
