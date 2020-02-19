using System;

namespace RPG_autoBattler
{
    public class BaseAttack : ISpell, IActiveSpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsPassive { get; set; }

        public bool IsRanged { get; set; }

        public void Cast(Char caster, Char victim)
        {
            victim.TakeDamage(caster, caster.Agility);
        }
    }
}
