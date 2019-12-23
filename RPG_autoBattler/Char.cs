using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public class Char
    {
        public Char()
            {
                Lvl = 1;
                StunTimer = 0;
            ActSpells = new List<Spell>();
            PasSpells = new List<Spell>();
            }

        public List<Spell> ActSpells { get; set; }

        public List<Spell> PasSpells { get; set; }

        public string Name { get; set; }

        public string Class { get; set; }

        public string Surname { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Lvl { get; set; }

        public int StunTimer { get; set; }

        public float MaxHP { get; set; }

        public float CurHP { get; set; }

        public void HitBySpell(Char caster, Spell spell)
        {
            try
            {
                foreach (var item in PasSpells)
                {
                    item.Trigger("HitBySpell", caster, this, spell.SpecVal);
                }

                spell.Cast(caster, this);
            }
            catch (ProtectException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TakeDamage(Char attacker, float dmg)
        {
            try
            {
                foreach (var item in PasSpells)
                {
                    var mass = new float[1] { dmg };
                    item.Trigger("TakeDamage", attacker, this, mass);
                }

                CurHP -= dmg;
                Logger.TakeDamageM(this, dmg);
            }
            catch (ProtectException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Heal(float hp)
        {
            if (hp < MaxHP - CurHP)
            {
                CurHP += hp;
            }
            else
            {
                CurHP = MaxHP;
            }
        }

        public void GainSpell(Spell spell)
        {
            switch (spell.IsPassive)
            {
                case 0: ActSpells.Add(spell); break;
                case 1: PasSpells.Add(spell); break;
                case 2: ActSpells.Add(spell); PasSpells.Add(spell); break;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Class})";
        }
    }
}
