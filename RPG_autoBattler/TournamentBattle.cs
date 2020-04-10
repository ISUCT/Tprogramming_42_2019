using System;
using System.Collections.Generic;

namespace RpgAutoBattler
{
    public enum TriggerType
    {
        StartBattle,
        EndBattle,
        StartTurn,
        EndTurn,
        DealDamage,
        TakeDamage,
        HitBySpell
    }

    public static class TournamentBattle
    {
        public static void MakeTurn(Character attacker, Character victim)
        {
            Random rnd = new Random();
            if (attacker.StunTimer == 0)
            {
                if (rnd.Next(0, 100) > 65)
                {
                    int ran = rnd.Next(1, attacker.ActSpells.Count);
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
                item.Trigger(TriggerType.EndTurn, attacker, victim, f);
            }

            foreach (IPassiveSpell item in victim.Effects)
            {
                float[] f = new float[1] { 1 };
                item.Trigger(TriggerType.EndTurn, victim, attacker, f);
            }
        }

        public static int Battle(Character a, Character b)
        {
            int turn = 1;
            a.StartBattle();
            b.StartBattle();
            foreach (IPassiveSpell item in b.PasSpells)
            {
                item.Trigger(TriggerType.StartBattle, b, a, null);
            }

            foreach (IPassiveSpell item in a.PasSpells)
            {
                item.Trigger(TriggerType.StartBattle, a, b, null);
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
                    item.Trigger(TriggerType.EndBattle, a, b, null);
                }

                return 1;
            }
            else
            {
                Console.WriteLine($"{b} wins!");
                b.Heal(b.MaxHP);
                foreach (IPassiveSpell item in b.Effects)
                {
                    item.Trigger(TriggerType.EndBattle, a, b, null);
                }

                return 0;
            }
        }

        public static Character Tournament(List<Character> charss)
        {
            List<Character> chars = charss;
            while (chars.Count > 1)
            {
                int i = 0;
                while (i < chars.Count - 1)
                {
                    Console.WriteLine($"Let the battle between {chars[i]} and {chars[i + 1]} begin!");
                    int r = Battle(chars[i], chars[i + 1]);
                    chars.RemoveAt(r + i);
                    i++;
                }
            }

            return chars[0];
        }

        public static int[] BalanceTest()
        {
            int palWin = 0;
            int ninjaWin = 0;
            int mageWin = 0;
            for (int i = 0; i < 100; i++)
            {
                Character pal = ReturnFuncs.ReturnRandomCharacter(new CharGenConfig());
                Character pal2 = ReturnFuncs.ReturnRandomCharacter(new CharGenConfig());
                Character ninja = ReturnFuncs.ReturnRandomCharacter(new CharGenConfig() { MinStrength = 5, MaxStrength = 15, MinAgility = 15, MaxAgility = 25, MinIntelligence = 1, MaxIntelligence = 5 }, CharacterClass.Ninja);
                Character ninja2 = ReturnFuncs.ReturnRandomCharacter(new CharGenConfig() { MinStrength = 5, MaxStrength = 15, MinAgility = 15, MaxAgility = 25, MinIntelligence = 1, MaxIntelligence = 5 }, CharacterClass.Ninja);
                Character mage = ReturnFuncs.ReturnRandomCharacter(new CharGenConfig() { MinStrength = 5, MaxStrength = 15, MinAgility = 1, MaxAgility = 5, MinIntelligence = 20, MaxIntelligence = 30 }, CharacterClass.Mage);
                Character mage2 = ReturnFuncs.ReturnRandomCharacter(new CharGenConfig() { MinStrength = 5, MaxStrength = 15, MinAgility = 1, MaxAgility = 5, MinIntelligence = 20, MaxIntelligence = 30 }, CharacterClass.Mage);
                List<Character> tourTest = new List<Character>() { pal, ninja, mage, pal2, ninja2, mage2 };
                Character winner = TournamentBattle.Tournament(tourTest);
                switch (winner.Class)
                {
                    case CharacterClass.Paladin: palWin++; break;
                    case CharacterClass.Ninja: ninjaWin++; break;
                    case CharacterClass.Mage: mageWin++; break;
                }
            }

            return new int[] { palWin, ninjaWin, mageWin };
        }
    }
}
