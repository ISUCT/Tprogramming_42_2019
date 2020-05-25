using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static void Combat(List<Player> fighters)
        {
            Random rnd = new Random();
            int val = rnd.Next(1, fighters.Count);

            foreach (Player fighter in fighters)
            {
                fighter.SetFullHp();
            }

            while (fighters.Count > 1)
            {
                Player a = fighters[rnd.Next(0, fighters.Count)];
                fighters.Remove(a);

                Player b = fighters[rnd.Next(0, fighters.Count)];
                fighters.Remove(b);

                a.SetFullHp();
                b.SetFullHp();
                while (a == b)
                {
                    a = fighters[rnd.Next(0, fighters.Count)];
                    b = fighters[rnd.Next(0, fighters.Count)];
                }

                while ((a.CurrentHp != 0) || (b.CurrentHp != 0))
                {
                    Console.WriteLine(a.Name);
                    Console.WriteLine(a.CurrentHp);
                    a.Attack(b);
                    Console.WriteLine(b.Name);
                    Console.WriteLine(b.CurrentHp);
                    b.Attack(a);
                    if (a.CurrentHp <= 0)
                    {
                        fighters.Add(b);
                        break;
                    }
                    else if (b.CurrentHp <= 0)
                    {
                        fighters.Add(a);
                        break;
                    }
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        public static List<Player> FighterGenerator(int count)
        {
            List<Player> fighters = new List<Player>();

            for (int i = 0; i < count; i++)
            {
                Player fighter = new Player();

                Random rnd = new Random();
                int val = rnd.Next(1, 3);

                switch (val)
                {
                    case 1:
                        fighter.SetClassName("Hunter");
                        fighter.Active = ReturnFuncs.GetHunterSpells();
                        break;
                    case 2:
                        fighter.SetClassName("Titan");
                        fighter.Active = ReturnFuncs.GetTitanSpells();
                        break;
                    case 3:
                        fighter.SetClassName("Warlock");
                        fighter.Active = ReturnFuncs.GetWarlockSpells();
                        break;
                }

                fighter.Strength = rnd.Next(10, 100);
                fighter.Agility = rnd.Next(10, 100);
                fighter.Intelligence = rnd.Next(10, 100);

                fighter.SetName();
                fighters.Add(fighter);
            }

            return fighters;
        }

        public static void Main(string[] args)
        {
            Player sample = new Player();
            Random rnd = new Random();
            int val = rnd.Next(2, 10);

            List<Player> fighters = new List<Player>();
            fighters = FighterGenerator(val);

            Combat(fighters);

            Console.WriteLine(fighters[0]);

            foreach (Player fighter in fighters)
            {
                Console.WriteLine(fighter.Name);
            }

            Console.ReadLine();
        }
    }
}
