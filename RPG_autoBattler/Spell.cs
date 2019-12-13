using System;

namespace RPG_autoBattler
{
    public delegate void TrigReal(string triggerType, Char attacker, Char victim, float[] specVal);

    public delegate void CastDel(Char caster, Char victim, float[] specVal);

    public class Spell
    {
        private TrigReal trigger;
        private CastDel cast;

        public bool IsRanged { get; set; }

        public bool IsActive { get; set; }

        public string Name { get; set; }

        public float MPcost { get; set; }

        public float[] SpecVal { get; set; }

        public int Lvl { get; set; }

        public void Trigger(string triggerType, Char attacker, Char victim, float[] specValue)
        {
            trigger(triggerType, attacker, victim, specValue);
        }

        public void Cast(Char caster, Char victim)
        {
            cast(caster, victim, SpecVal);
        }
    }
}
