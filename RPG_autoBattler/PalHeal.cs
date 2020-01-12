using System;

namespace RPG_autoBattler
{
    public class PalHeal : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        public float HP { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            caster.Heal(HP);
        }
    }
}
