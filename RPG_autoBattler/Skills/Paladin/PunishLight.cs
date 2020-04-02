using System;

namespace RpgAutoBattler
{
    public class PunishLight : ISpell
    {
        public string Name { get; set; } = "Punishing Light";

        public int Lvl { get; set; }

        public bool IsPassive { get; set; } = false;

        public bool IsRanged { get; set; } = false;

        public float Damage { get; set; }

        public void Cast(Character caster, Character victim)
        {
            victim.TakeDamage(caster, Damage);
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
