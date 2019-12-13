﻿using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public class Char
    {
        public Char()
            {
                Lvl = 1;
                StunTimer = 0;
            Spells = new List<Spell>();
            }

        public List<Spell> Spells { get; set; }

        public string Name { get; set; }

        public string Class { get; set; }

        public string Surname { get; set; }

        public int Str { get; set; }

        public int Agi { get; set; }

        public int Int { get; set; }

        public int Lvl { get; set; }

        public int StunTimer { get; set; }

        public float MaxHP { get; set; }

        public float MaxMP { get; set; }

        public float CurHP { get; set; }

        public float CurMP { get; set; }

        public void HitBySpell(Char caster, Spell spell)
        {
            try
            {
                foreach (var item in Spells)
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
                foreach (var item in Spells)
                {
                    var mass = new float[1] { dmg };
                    item.Trigger("TakeDamage", attacker, this, mass);
                }

                CurHP -= dmg;
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
