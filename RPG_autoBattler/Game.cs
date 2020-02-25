using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public class Game
    {
        public static void Main()
        {
            /*palaSpells = ReturnFuncs.RetPalSpells();
            ninjaSpells = ReturnFuncs.RetNinjaSpells();
            mageSpells = ReturnFuncs.RetMageSpells();*/
            List<string> names = ReturnFuncs.RetNames();
            List<string> surnames = ReturnFuncs.RetSurnames();
            List<Char> fighters = new List<Char>();

            // List<string> names;
            // RetNames().CopyTo(names);
            // palSpells.Add(palBaseAttack);
            Console.WriteLine("Welcome to the Battle for Glory Arena. Press any key to start");
            /*Console.ReadKey();
            Console.WriteLine("Choose your class, type 'Paladin', 'Ninja' or 'Mage' here: ");
            string playerClass = Console.ReadLine();
            while ((playerClass != "Paladin") && (playerClass != "Ninja") && (playerClass != "Mage"))
            {
                Console.WriteLine("Error recognizing class, try to write again or copy and paste class name here: ");
                playerClass = Console.ReadLine();
            }*/

            // Char winner = TournamentBattle.Tournament(ReturnFuncs.RetFighters(4));
            // Console.WriteLine($"{winner} won the tournament!");
            Char pal = ReturnFuncs.ReturnRandomChar();
            Char pal2 = ReturnFuncs.ReturnRandomChar();
            Char ninja = ReturnFuncs.ReturnRandomChar("Ninja", 5, 15, 15, 25, 1, 5);
            Char ninja2 = ReturnFuncs.ReturnRandomChar("Ninja", 5, 15, 15, 25, 1, 5);
            Char mage = ReturnFuncs.ReturnRandomChar("Mage", 5, 15, 1, 5, 20, 30);
            Char mage2 = ReturnFuncs.ReturnRandomChar("Mage", 5, 15, 1, 5, 20, 30);
            int palWin = 0;
            int ninjaWin = 0;
            int mageWin = 0;
            for (int i = 0; i < 100; i++)
            {
                List<Char> tourTest = new List<Char>() { pal, ninja, mage, pal2, ninja2, mage2 };
                Char winner = TournamentBattle.Tournament(tourTest);
                if (winner.Class == "Paladin")
                {
                    palWin++;
                }
                else
                {
                if (winner.Class == "Ninja")
                    {
                        ninjaWin++;
                    }
                    else if (winner.Class == "Mage")
                {
                    mageWin++;
                }
                else
                {
                    Console.WriteLine("WTF");
                }
                }
            }

            Console.WriteLine($"Pal:  {palWin} Ninja: {ninjaWin} Mage: {mageWin}");
            Console.ReadKey();
        }
    }
}