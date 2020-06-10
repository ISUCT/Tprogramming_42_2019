using System;
using System.Collections.Generic;

namespace RPG
{
    public struct Fight
    {
        public Hero hero1;
        public Hero hero2;
    }

    public class Fights
    {

        static Logger logger = new Logger();
        static Random rnd = new Random();
        static List<Fight> fight = new List<Fight>();
        static int rounds = 0;

        static void CreateFights()
        {
            while (Game.heroes.Count > 1)
            {
                int k = rnd.Next(0, Game.heroes.Count - 1);
                Fight fights = new Fight();
                fights.hero1 = Game.heroes[k];
                Game.heroes.RemoveAt(k);

                k = rnd.Next(0, Game.heroes.Count);
                fights.hero2 = Game.heroes[k];
                Game.heroes.RemoveAt(k);

                fight.Add(fights);
            }
        }

        static void Atack(Hero attacking, Hero attacked)
        {
            int damage;
        
            if(attacking.buf)
            {
                damage = attacking.Atack();
                logger.Atack(attacking, attacked, damage);
                attacked.GetDamage(damage + attacking.bufDamage);
            }
            else
            {    
                damage = attacking.Atack();
                logger.Atack(attacking, attacked, damage);
                attacked.GetDamage(damage);
            }
        }

        static void Skill(Hero attacking, Hero attacked)
        {
            int damage;

            if(attacking.buf || attacking.sleepTime > 0)
            {
                Atack(attacking, attacked);
            }
            else
            {    
                damage = attacking.Skill();
                logger.Skill(attacking, attacked, attacking.skillName, damage);
                attacked.GetDamage(damage);
            }
        }

        static void Win(Hero winner, Hero loser)
        {
            winner.sleepTime = 0;
            winner.buf = false;
            Game.heroes.Add(winner);
            logger.Win(winner);
            logger.Death(loser);
        }

        public static void Fight()
        {
            CreateFights();
            int i = rnd.Next(0, fight.Count);
            Hero hero1 = fight[i].hero1;
            Hero hero2 = fight[i].hero2;
            fight.RemoveAt(i);

            int turn = rnd.Next(0, 1);
            rounds++;
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine($"Round №{rounds}\n");
            while (true)
            {
             
                if(turn == 0)
                {
                    if(hero2.sleepTime == 0)
                    {
                        if(rnd.Next(0,10) > 6)
                        {
                            Skill(hero1, hero2);
                        }
                        else
                        {
                            Atack(hero1, hero2);
                        }
                    }
                    else
                    {
                        logger.Sleep(hero1);
                        hero2.sleepTime--;
                    }

                    if(hero2.Health <= 0)
                    {
                        Win(hero1, hero2);
                        if(fight.Count == 0)
                        {
                            break;
                        }

                        i = rnd.Next(0, fight.Count);
                        hero1 = fight[i].hero1;
                        hero2 = fight[i].hero2;
                        fight.RemoveAt(i);
                    }
                     
                  

                    turn = 1;
                }
                else
                {
                    if(hero1.sleepTime == 0)
                    {
                        if(rnd.Next(0,10) > 6)
                        {
                            Skill(hero2, hero1);
                        }
                        else
                        {
                            Atack(hero2, hero1);
                        }
                    }
                    else
                    {
                        logger.Sleep(hero2);
                        hero1.sleepTime--;
                    }

                    if(hero1.Health <= 0)
                    {
                        Win(hero2, hero1);
                        if(fight.Count == 0)
                        {
                            break;
                        }
                        i = rnd.Next(0, fight.Count);
                        hero1 = fight[i].hero1;
                        hero2 = fight[i].hero2;
                        fight.RemoveAt(i);
                    }

                    

                    turn = 0;
                }
            }
        }
    }
}
