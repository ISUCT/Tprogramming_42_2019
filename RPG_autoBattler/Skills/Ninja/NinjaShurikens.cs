using System;

namespace RpgAutoBattler
{
    public class NinjaShurikens : ISpell
    {
        public string Name { get; set; } = "Shurikens Throw";

        public int Lvl { get; set; }

        public float Damage { get; set; }

        public int Count { get; set; }

        public bool IsPassive { get; set; } = false;

        public bool IsRanged { get; set; } = true;

        public void Cast(Character caster, Character victim)
        {
            for (int i = 0; i < Count; i++)
            {
                victim.TakeDamage(caster, Damage);
            }
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
