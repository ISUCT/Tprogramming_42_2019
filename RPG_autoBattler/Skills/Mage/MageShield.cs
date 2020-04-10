using System;

namespace RpgAutoBattler
{
    public class MageShield : ISpell
    {
        public string Name { get; set; } = "Magic Shield";

        public int Lvl { get; set; }

        public bool IsRanged { get; set; } = false;

        public bool IsPassive { get; set; } = false;

        public int Duration { get; set; }

        public void Cast(Character caster, Character victim)
        {
            MageShielded mageShielded = new MageShielded
            {
                TurnsLeft = Duration
            };
            caster.Effects.Add(mageShielded);
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
