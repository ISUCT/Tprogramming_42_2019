using System;

namespace RPG_autoBattler
{
    public class MageShield : ISpell, IActiveSpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsRanged { get; set; }

        public int Duration { get; set; }

        public void Cast(Char caster, Char victim)
        {
            MageShielded mageShielded = new MageShielded();
            mageShielded.TurnsLeft = Duration;
            caster.Effects.Add(mageShielded);
        }
    }
}
