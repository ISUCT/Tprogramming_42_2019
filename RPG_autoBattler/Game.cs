using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public class Game
    {
        private static List<Spell> palSpells = new List<Spell>();

        public static int Battle(Char a, Char b)
        {
            Random rnd = new Random();
            int turn = 1;
            while ((a.CurHP > 0) && (b.CurHP > 0))
            {
                Console.Write($"Turn {turn}: ");
                if ((turn % 2) == 0)
                {
                    b.HitBySpell(a, a.Spells[rnd.Next(0, a.Spells.Count - 1)]);
                }
                else
                {
                    a.HitBySpell(b, b.Spells[rnd.Next(0, b.Spells.Count - 1)]);
                }

                turn++;
            }

            if (a.CurHP > 0)
            {
                Console.WriteLine($"{a.Name} {a.Surname} ({a.Class}) wins!");
                a.Heal(a.MaxHP);
                return 0;
            }
            else
            {
                Console.WriteLine($"{b.Name} {b.Surname} ({b.Class}) wins!");
                b.Heal(b.MaxHP);
                return 1;
            }
        }

        public static void Main()
        {
            Spell palBaseAttack = new Spell(1);
            palBaseAttack.IsRanged = false;
            palBaseAttack.Lvl = 1;
            palBaseAttack.MPcost = 0;
            palBaseAttack.Name = "Base Attack";
            palBaseAttack.Castt = BaseAttackFunc;
            palBaseAttack.Triggerr = TrigEmpty;
            palBaseAttack.SpecVal[0] = 10;
            palSpells.Add(palBaseAttack);

            // palSpells.Add(palBaseAttack);
            Console.WriteLine("Welcome to the Battle for Glory Arena. Press any key to start");
            Console.ReadKey();
            Console.WriteLine("Choose your class, type 'Paladin', 'Ninja' or 'Mage' here: ");
            string playerClass = Console.ReadLine();
            while ((playerClass != "Paladin") && (playerClass != "Ninja") && (playerClass != "Mage"))
            {
                Console.WriteLine("Error recognizing class, try to write again or copy and paste class name here: ");
                playerClass = Console.ReadLine();
            }

            Char player = new Char();
            player.Class = playerClass;
            player.CurHP = 30;
            player.Spells.Add(palSpells[0]);
            player.Name = "Arthas";
            player.Surname = "Menethil";
            Char vict = new Char();
            vict.Class = playerClass;
            vict.Spells.Add(palSpells[0]);
            vict.Name = "Bolvar";
            vict.Surname = "Fordragon";
            vict.CurHP = 20;
            Battle(player, vict);
            /*Console.WriteLine($"Victim has {vict.CurHP} HP");
            vict.HitBySpell(player, player.Spells[0]);
            Console.WriteLine($"And now he has {vict.CurHP} HP");*/
            Console.ReadKey();
        }

        public static void BaseAttackFunc(Char caster, Char victim, float[] specVal)
        {
            victim.TakeDamage(caster, specVal[0]);
        }

        public static void TrigEmpty(string triggerType, Char attacker, Char victim, float[] specVal)
        {
        }
    }
}
