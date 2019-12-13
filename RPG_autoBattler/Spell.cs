using System;

namespace RPG_autoBattler
{
    public delegate void TrigReal(string triggerType, Char attacker, Char victim, float[] specVal);

    public delegate void CastDel(Char caster, Char victim, float[] specVal);

    public class Spell
    {
        public Spell(int count)
        {
            SpecVal = new float[count];
        }

        public TrigReal Triggerr { get; set; }

        public CastDel Castt { get; set; }

        public bool IsRanged { get; set; }

        public bool IsActive { get; set; }

        public string Name { get; set; }

        public float MPcost { get; set; }

        public float[] SpecVal { get; set; }

        public int Lvl { get; set; }

        public void Trigger(string triggerType, Char attacker, Char victim, float[] specValue)
        {
            Triggerr(triggerType, attacker, victim, specValue);
        }

        public void Cast(Char caster, Char victim)
        {
            Castt(caster, victim, SpecVal);
        }
    }
}
