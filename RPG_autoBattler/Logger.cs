using System;
using System.Collections.Generic;

namespace RpgAutoBattler
{
    public static class Logger
    {
        public static void SpellCastM(Character caster, ISpell spell)
        {
            Console.WriteLine($"{caster.ToString()} uses {spell.Name}!");
        }

        public static void TakeDamageM(Character victim, float dmg)
        {
            Console.WriteLine($"{victim.ToString()} takes {dmg} damage! {victim.CurHP} HP left!");
        }

        public static void StunM(Character victim, int turns)
        {
            Console.WriteLine($"{victim.ToString()} is stunned for {turns} turn(s)!");
        }

        public static void HealM(Character target, float value)
        {
            Console.WriteLine($"{target} is healed by {value} HP! {target.CurHP} HP left!");
        }
    }
}
