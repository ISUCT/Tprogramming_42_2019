using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public static class TournamentBattle
    {
        public static void MakeTurn(Char attacker, Char victim)
        {
            Random rnd = new Random();
            if (attacker.StunTimer == 0)
            {
                if (rnd.Next(0, 100) > 65)
                {
                    int ran = rnd.Next(1, attacker.ActSpells.Count);

                    // Console.WriteLine($"Random = {ran}");
                    victim.HitBySpell(attacker, attacker.ActSpells[ran]);
                }
                else
                {
                    victim.HitBySpell(attacker, attacker.ActSpells[0]);
                }
            }
            else
            {
                attacker.StunTimer--;
                Console.WriteLine($"{attacker} is stunned! {attacker.StunTimer} turn(s) left.");
            }

            foreach (IPassiveSpell item in attacker.Effects)
            {
                float[] f = new float[1] { 0 };
                item.Trigger("EndTurn", attacker, victim, f);
            }

            foreach (IPassiveSpell item in victim.Effects)
            {
                float[] f = new float[1] { 1 };
                item.Trigger("EndTurn", victim, attacker, f);
            }
        }

        public static int Battle(Char a, Char b)
        {
            Random rnd = new Random();
            int turn = 1;
            a.Effects = new List<IPassiveSpell>();
            b.Effects = new List<IPassiveSpell>();
            foreach (IPassiveSpell item in b.PasSpells)
            {
                item.Trigger("StartBattle", b, a, null);
            }

            foreach (IPassiveSpell item in a.PasSpells)
            {
                item.Trigger("StartBattle", a, b, null);
            }

            while ((a.CurHP > 0) && (b.CurHP > 0))
            {
                Console.WriteLine($"Turn {turn}: ");
                if ((turn % 2) == 0)
                {
                    MakeTurn(a, b);
                }
                else
                {
                    MakeTurn(b, a);
                }

                turn++;
            }

            if (a.CurHP > 0)
            {
                Console.WriteLine($"{a} wins!");
                a.Heal(a.MaxHP);
                foreach (IPassiveSpell item in a.Effects)
                {
                    item.Trigger("EndBattle", a, b, null);
                }

                return 1;
            }
            else
            {
                Console.WriteLine($"{b} wins!");
                b.Heal(b.MaxHP);
                foreach (IPassiveSpell item in b.Effects)
                {
                    item.Trigger("EndBattle", a, b, null);
                }

                return 0;
            }
        }

        public static Char Tournament(List<Char> charss)
        {
            List<Char> chars = charss;
            while (chars.Count > 1)
            {
                int i = 0;
                while (i < chars.Count)
                {
                    Console.WriteLine($"Let the battle between {chars[i]} and {chars[i + 1]} begin!");
                    int r = Battle(chars[i], chars[i + 1]);
                    chars.RemoveAt(r + i);
                    i++;
                }
            }

            return chars[0];
        }
    }
}
