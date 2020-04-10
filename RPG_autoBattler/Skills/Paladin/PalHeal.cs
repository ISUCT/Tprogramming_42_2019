using System;

namespace RpgAutoBattler
{
    public class PalHeal : ISpell
    {
        public string Name { get; set; } = "Faith in the Light";

        public int Lvl { get; set; }

        public bool IsPassive { get; set; } = false;

        public bool IsRanged { get; set; } = false;

        public float HP { get; set; }

        public void Cast(Character caster, Character victim)
        {
            caster.Heal(HP);
            Logger.HealM(caster, HP);
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
