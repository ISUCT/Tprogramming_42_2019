using System;
using System.Collections.Generic;

namespace RpgAutoBattler
{
    public class Game
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Battle for Glory Arena");
            Character winner = TournamentBattle.Tournament(ReturnFuncs.RetFighters(4));
            Console.WriteLine($"{winner} is the winner of the tournament!");
            Console.ReadKey();
        }
    }
}