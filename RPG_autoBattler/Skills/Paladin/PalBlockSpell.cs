using System;

namespace RpgAutoBattler
{
    public class PalBlockSpell : ISpell, IPassiveSpell
    {
        public string Name { get; set; } = "Shield";

        public int Lvl { get; set; }

        public int TurnsLeft { get; set; }

        public float DamageBlockPercent { get; set; }

        public bool IsPassive { get; set; } = true;

        public int StunDuration { get; set; }

        public bool IsRanged { get; set; } = false;

        public void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == TriggerType.StartBattle)
            {
                PalBlock palBlock = new PalBlock
                {
                    DamageBlockPercent = DamageBlockPercent,
                    TurnsLeft = 1
                };
                attacker.Effects.Add(palBlock);
            }
        }

        public void Cast(Character caster, Character victim)
        {
        }
    }
}
