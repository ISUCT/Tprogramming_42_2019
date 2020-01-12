using System;
using System.Collections.Generic;
using System.Collections;

namespace RPG_autoBattler
{
    public class Char
    {
        public Char()
            {
                Lvl = 1;
                StunTimer = 0;
            ActSpells = new List<IActiveSpell>();
            PasSpells = new List<IPassiveSpell>();
            Effects = new List<IPassiveSpell>();
            }

        public List<IActiveSpell> ActSpells { get; set; }

        public List<IPassiveSpell> PasSpells { get; set; }

        public List<IPassiveSpell> Effects { get; set; }

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

        public void HitBySpell(Char caster, IActiveSpell spell)
        {
            try
            {
                foreach (var item in Effects)
                {
                    item.Trigger("HitBySpell", caster, this, null);
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
                foreach (var item in Effects)
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

        public void GainSpell(IActiveSpell spell)
        {
                ActSpells.Add(spell);
        }

        public void GainSpell(IPassiveSpell spell)
        {
            PasSpells.Add(spell);
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Class})";
        }
    }
}
