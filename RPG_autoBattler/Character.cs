using System;
using System.Collections.Generic;
using System.Collections;

namespace RpgAutoBattler
{
    public class Character
    {
        public Character()
            {
                Lvl = 1;
                StunTimer = 0;
            ActSpells = new List<ISpell>();
            PasSpells = new List<ISpell>();
            Effects = new List<IPassiveSpell>();
            }

        public List<ISpell> ActSpells { get; set; }

        public List<ISpell> PasSpells { get; set; }

        public List<IPassiveSpell> Effects { get; set; }

        public string Name { get; set; }

        public CharacterClass Class { get; set; }

        public string Surname { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Lvl { get; set; }

        public int StunTimer { get; set; }

        public float MaxHP { get; set; }

        public float CurHP { get; set; }

        public void HitBySpell(Character caster, ISpell spell)
        {
            try
            {
                foreach (var item in Effects)
                {
                    item.Trigger(TriggerType.HitBySpell, caster, this, null);
                }

                Logger.SpellCastM(caster, (ISpell)spell);
                spell.Cast(caster, this);
            }
            catch (ProtectException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TakeDamage(Character attacker, float dmg)
        {
            try
            {
                foreach (var item in Effects)
                {
                    var mass = new float[1] { dmg };
                    item.Trigger(TriggerType.TakeDamage, attacker, this, mass);
                }

                foreach (var item in attacker.PasSpells)
                {
                    var mass = new float[1] { dmg };
                    item.Trigger(TriggerType.DealDamage, attacker, this, mass);
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

        public void GainSpell(ISpell spell)
        {
                if (spell.IsPassive == false)
            {
                ActSpells.Add(spell);
            }
            else
            {
                PasSpells.Add(spell);
            }
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Class})";
        }

        public void StartBattle()
        {
            CurHP = MaxHP;
            Effects.Clear();
        }
    }
}
