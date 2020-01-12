using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public static class TournamentBattle
    {
        public static int Battle(Char a, Char b)
        {
            Random rnd = new Random();
            int turn = 1;
            a.Effects = new List<IPassiveSpell>();
            foreach (IPassiveSpell item in b.Effects)
            {
                item.Trigger("BattleStart", b, a, null);
            }

            foreach (IPassiveSpell item in a.Effects)
            {
                item.Trigger("BattleStart", a, b, null);
            }

            while ((a.CurHP > 0) && (b.CurHP > 0))
            {
                Console.WriteLine($"Turn {turn}: ");
                if ((turn % 2) == 0)
                {
                    if (a.StunTimer == 0)
                    {
                        if (rnd.Next(0, 100) > 65)
                        {
                            int ran = rnd.Next(1, a.ActSpells.Count);

                            // Console.WriteLine($"Random = {ran}");
                            b.HitBySpell(a, a.ActSpells[ran]);
                        }
                        else
                        {
                            b.HitBySpell(a, a.ActSpells[0]);
                        }
                    }
                    else
                    {
                        a.StunTimer--;
                        Console.WriteLine($"{a.Name} {a.Surname} ({a.Class}) is stunned! {a.StunTimer} turn(s) left.");
                    }

                    foreach (IPassiveSpell item in a.Effects)
                    {
                        float[] f = new float[1] { 0 };
                        item.Trigger("TurnEnd", a, b, f);
                    }

                    foreach (IPassiveSpell item in b.Effects)
                    {
                        float[] f = new float[1] { 1 };
                        item.Trigger("TurnEnd", b, a, f);
                    }
                }
                else
                {
                    if (b.StunTimer == 0)
                    {
                        if (rnd.Next(0, 100) > 65)
                        {
                            int ran = rnd.Next(1, b.ActSpells.Count);

                            // Console.WriteLine($"Random = {ran}");
                            a.HitBySpell(b, b.ActSpells[ran]);
                        }
                        else
                        {
                            a.HitBySpell(b, b.ActSpells[0]);
                        }
                    }
                    else
                    {
                        b.StunTimer--;
                        Console.WriteLine($"{b} is stunned! {b.StunTimer} turn(s) left.");
                    }

                    foreach (IPassiveSpell item in b.Effects)
                    {
                        float[] f = new float[1] { 0 };
                        item.Trigger("TurnEnd", b, a, f);
                    }

                    foreach (IPassiveSpell item in a.Effects)
                    {
                        float[] f = new float[1] { 1 };
                        item.Trigger("TurnEnd", a, b, f);
                    }
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
                    Console.WriteLine($"Let the battle between {chars[i].Name} {chars[i].Surname} ({chars[i].Class}) and {chars[i + 1].Name} {chars[i + 1].Surname} ({chars[i + 1].Class}) begin!");
                    int r = Battle(chars[i], chars[i + 1]);
                    chars.RemoveAt(r + i);
                    i++;
                }
            }

            return chars[0];
        }
    }
}
