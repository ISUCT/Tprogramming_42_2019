using System;
using System.Collections;

namespace RPG_autoBattler
{
    public class Game
    {
        private ArrayList palSpells = new ArrayList();

        public static int Battle(Char a, Char b)
        {
            return 0;
        }

        public static void Main()
        {
            Spell palBaseAttack = new Spell(1);
            palBaseAttack.Castt = BaseAttackFunc;
            palBaseAttack.SpecVal[0] = 10;

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
            player.Spells.Add(palBaseAttack);
            Char vict = new Char();
            vict.CurHP = 20;
            Console.WriteLine($"Victim has {vict.CurHP} HP");
            vict.HitBySpell(player, player.Spells[0]);
            Console.WriteLine($"And now he has {vict.CurHP} HP");
            Console.ReadKey();
        }

        public static void BaseAttackFunc(Char caster, Char victim, float[] specVal)
        {
            victim.TakeDamage(caster, specVal[0]);
        }
    }
}
