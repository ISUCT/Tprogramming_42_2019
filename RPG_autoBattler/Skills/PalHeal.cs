using System;

namespace RPG_autoBattler
{
    public class PalHeal : ISpell, IActiveSpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsPassive { get; set; }

        public bool IsRanged { get; set; }

        public float HP { get; set; }

        public void Cast(Char caster, Char victim)
        {
            caster.Heal(HP);
            Logger.HealM(caster, HP);
        }
    }
}
