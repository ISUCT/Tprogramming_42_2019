using System;

namespace RPG_autoBattler
{
    public class PunishLight : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsPassive { get; set; }

        public bool IsRanged { get; set; }

        public float Damage { get; set; }

        public void Cast(Character caster, Character victim)
        {
            victim.TakeDamage(caster, Damage);
        }

        public void Trigger(string s, Character a, Character b, float[] f)
        {
        }
    }
}
