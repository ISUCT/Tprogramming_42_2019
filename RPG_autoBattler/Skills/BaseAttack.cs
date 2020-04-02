using System;

namespace RpgAutoBattler
{
    public class BaseAttack : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsPassive { get; set; } = false;

        public bool IsRanged { get; set; }

        public void Cast(Character caster, Character victim)
        {
            victim.TakeDamage(caster, caster.Agility);
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
