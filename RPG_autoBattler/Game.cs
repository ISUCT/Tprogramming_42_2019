using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public class Game
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Battle for Glory Arena. Press any key to start");
            /*Console.ReadKey();
            Console.WriteLine("Choose your class, type 'Paladin', 'Ninja' or 'Mage' here: ");
            string playerClass = Console.ReadLine();
            while ((playerClass != "Paladin") && (playerClass != "Ninja") && (playerClass != "Mage"))
            {
                Console.WriteLine("Error recognizing class, try to write again or copy and paste class name here: ");
                playerClass = Console.ReadLine();
            }*/

            Character winner = TournamentBattle.Tournament(ReturnFuncs.RetFighters(4));
            Console.WriteLine($"{winner} is the winner of the tournament!");

            /*int[] a = new int[3];
            a = TournamentBattle.BalanceTest();
            Console.WriteLine($"Pal:  {a[0]} Ninja: {a[1]} Mage: {a[2]}");*/
            Console.ReadKey();
        }
    }
}