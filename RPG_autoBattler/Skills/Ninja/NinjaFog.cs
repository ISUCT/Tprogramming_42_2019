using System;

namespace RpgAutoBattler
{
    public class NinjaFog : ISpell
    {
        public string Name { get; set; } = "Smoke Screen";

        public int Lvl { get; set; }

        public bool IsRanged { get; set; } = false;

        public int DodgeChance { get; set; }

        public bool IsPassive { get; set; } = false;

        public int Duration { get; set; }

        public void Cast(Character caster, Character victim)
        {
            FogHide fogHide = new FogHide
            {
                DodgeChance = DodgeChance,
                TurnsLeft = Duration
            };
            caster.Effects.Add(fogHide);
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
