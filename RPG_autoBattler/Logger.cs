using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public static class Logger
    {
        public static void SpellCastM(Char caster, Spell spell)
        {
            Console.WriteLine($"{caster.ToString()} uses {spell.Name}!");
        }

        public static void TakeDamageM(Char victim, float dmg)
        {
            Console.WriteLine($"{victim.ToString()} takes {dmg} damage! {victim.CurHP} HP left!");
        }

        public static void StunM(Char victim, int turns)
        {
            Console.WriteLine($"{victim.ToString()} is stunned for {turns} turn(s)!");
        }
    }
}
