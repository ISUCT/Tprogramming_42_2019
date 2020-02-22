using System;

namespace RPG_autoBattler
{
    public class NinjaFog : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public bool IsRanged { get; set; }

        public int DodgeChance { get; set; }

        public bool IsPassive { get; set; }

        public int Duration { get; set; }

        public void Cast(Char caster, Char victim)
        {
            FogHide fogHide = new FogHide();
            fogHide.DodgeChance = DodgeChance;
            fogHide.TurnsLeft = Duration;
            caster.Effects.Add(fogHide);
        }

        public void Trigger(string s, Char a, Char b, float[] f)
        {
        }
    }
}
