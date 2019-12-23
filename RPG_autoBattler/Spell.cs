﻿using System;

namespace RPG_autoBattler
{
    public delegate void TrigReal(string triggerType, Char attacker, Char victim, float[] specVal, float[] innerVal);

    public delegate void CastDel(Char caster, Char victim, float[] specVal);

    public class Spell
    {
        private float[] specVal;

        public Spell(int count)
        {
            SpecVal = new float[count];
        }

        public TrigReal Triggerr { get; set; }

        public CastDel Castt { get; set; }

        public bool IsRanged { get; set; }

        public int IsPassive { get; set; }

        public string Name { get; set; }

        public float[] SpecVal
        {
            get
            {
                return this.specVal;
            }

            set
            {
                    this.specVal = value;
            }
        }

        public int Lvl { get; set; }

        public void Trigger(string triggerType, Char attacker, Char victim, float[] specValue)
        {
            Triggerr(triggerType, attacker, victim, specValue, specVal);
        }

        public void Cast(Char caster, Char victim)
        {
            Logger.SpellCastM(caster, this);
            Castt(caster, victim, specVal);
        }
    }
}
