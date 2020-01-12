using System;

namespace RPG_autoBattler
{
    public class NinjaShurikens : ISpell, IActiveSpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public float Damage { get; set; }

        public int Count { get; set; }

        public bool IsRanged { get; set; }

        public void Cast(Char caster, Char victim)
        {
            for (int i = 0; i < Count; i++)
            {
                victim.TakeDamage(caster, Damage);
            }
        }
    }
}
