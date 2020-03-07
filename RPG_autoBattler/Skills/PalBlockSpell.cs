using System;

namespace RPG_autoBattler
{
    public class PalBlockSpell : ISpell, IPassiveSpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public int TurnsLeft { get; set; }

        public float DamageBlockPercent { get; set; }

        public bool IsPassive { get; set; }

        public int StunDuration { get; set; }

        public bool IsRanged { get; set; }

        public void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == TriggerType.StartBattle)
            {
                PalBlock palBlock = new PalBlock();
                palBlock.DamageBlockPercent = DamageBlockPercent;
                palBlock.TurnsLeft = 1;
                attacker.Effects.Add(palBlock);
            }
        }

        public void Cast(Character caster, Character victim)
        {
        }
    }
}
