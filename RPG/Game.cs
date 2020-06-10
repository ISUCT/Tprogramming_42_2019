using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        public static List<Hero> heroes = new List<Hero>();
        Random rnd = new Random();

        public void Start(int numOfHeroes)
        {
            CreateHeroes(numOfHeroes);
            while(heroes.Count != 1)
            {
                Fights.Fight();
            }

            Console.WriteLine("_____________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWinner - {heroes[0].Name} ({heroes[0].heroClass})");
            Console.ResetColor();   
        }

        public void CreateHeroes(int numOfHeroes)
        {

            while(numOfHeroes > 0)
            {
                switch(rnd.Next(0,3))
                {
                    case 0: 
                        heroes.Add(new Archer());
                        break;
                    case 1:
                        heroes.Add(new Knight());
                        break;
                    case 2:
                        heroes.Add(new Mage());
                        break;
                    default:
                        heroes.Add(new Mage());
                        break;
                }
                numOfHeroes--;
            }
        }
    }
}
