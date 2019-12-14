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

        public int Str { get; set; }

        public int Agi { get; set; }

        public int Int { get; set; }

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
                Console.WriteLine($"{Name} {Surname} ({Class}) takes {dmg} damage! {CurHP} HP left!");
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
    }
}
