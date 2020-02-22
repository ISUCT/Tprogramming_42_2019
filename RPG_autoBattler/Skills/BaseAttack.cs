using System;

namespace RPG_autoBattler
{
    public class BaseAttack : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsPassive { get; set; }

        public bool IsRanged { get; set; }

        public void Cast(Char caster, Char victim)
        {
            victim.TakeDamage(caster, caster.Agility);
        }

        public void Trigger(string s, Char a, Char b, float[] f)
        {
        }
    }
}
