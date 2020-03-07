using System;

namespace RPG_autoBattler
{
    public class NinjaPierce : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public float Damage { get; set; }

        public bool IsPassive { get; set; }

        public bool IsRanged { get; set; }

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
