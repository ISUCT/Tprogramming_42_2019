using System;

namespace RPG_autoBattler
{
    public class PalHeal : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsPassive { get; set; }

        public bool IsRanged { get; set; }

        public float HP { get; set; }

        public void Cast(Character caster, Character victim)
        {
            caster.Heal(HP);
            Logger.HealM(caster, HP);
        }

        public void Trigger(string s, Character a, Character b, float[] f)
        {
        }
    }
}
