using System;

namespace RPG_autoBattler
{
    public class Burning : IPassiveSpell
    {
        public float Damage { get; set; }

        public int TurnsLeft { get; set; }

        void IPassiveSpell.Trigger(string triggerType, Char attacker, Char victim, float[] specVal)
        {
            if ((triggerType == "EndTurn") && (specVal[0] == 0))
            {
                victim.TakeDamage(attacker, Damage);
            }
        }
    }
}
