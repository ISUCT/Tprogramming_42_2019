using System;

namespace RPG_autoBattler
{
    public class PalBlockSpell : ISpell, IPassiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        public int TurnsLeft { get; set; }

        public int StunDuration { get; set; }

        void IPassiveSpell.Trigger(string triggerType, Char attacker, Char victim, float[] specValue)
        {
            if (triggerType == "StartBattle")
            {
                PalBlock palBlock = new PalBlock();
                palBlock.DamageBlockPercent = 25;
                palBlock.TurnsLeft = 1;
                attacker.Effects.Add(palBlock);
            }
        }
    }
}
