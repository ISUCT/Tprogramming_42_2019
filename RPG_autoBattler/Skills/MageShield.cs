using System;

namespace RPG_autoBattler
{
    public class MageShield : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsRanged { get; set; }

        public bool IsPassive { get; set; }

        public int Duration { get; set; }

        public void Cast(Character caster, Character victim)
        {
            MageShielded mageShielded = new MageShielded();
            mageShielded.TurnsLeft = Duration;
            caster.Effects.Add(mageShielded);
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
