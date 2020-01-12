using System;

namespace RPG_autoBattler
{
    public class NinjaFog : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            FogHide fogHide = new FogHide();
            fogHide.DodgeChance = 25;
            fogHide.TurnsLeft = 3;
            caster.Effects.Add(fogHide);
        }
    }
}
