using System;

namespace RpgAutoBattler
{
    public class NinjaPierce : ISpell
    {
        public string Name { get; set; } = "Piercing Slash";

        public int Lvl { get; set; }

        public float Damage { get; set; }

        public bool IsPassive { get; set; } = false;

        public bool IsRanged { get; set; } = false;

        public void Cast(Character caster, Character victim)
        {
            victim.CurHP -= caster.Agility + Damage;
            Logger.TakeDamageM(victim, caster.Agility + Damage);
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
