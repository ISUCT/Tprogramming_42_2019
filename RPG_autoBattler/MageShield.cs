using System;

namespace RPG_autoBattler
{
    public class MageShield : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        public int Duration { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            MageShielded mageShielded = new MageShielded();
            mageShielded.TurnsLeft = Duration;
            caster.Effects.Add(mageShielded);
        }
    }
}
