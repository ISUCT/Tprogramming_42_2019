using System;

namespace RPG_autoBattler
{
    public class NinjaShurikens : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        public float Damage { get; set; }

        public int Count { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            for (int i = 0; i < Count; i++)
            {
                victim.TakeDamage(caster, Damage);
            }
        }
    }
}
