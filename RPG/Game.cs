using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public class Game
    {
        private static int team1Points = 0;
        private static int team2Points = 0;

        static void Main(string[] args)
        {
            List<Player> team1 = new List<Player>();
            List<Player> team2 = new List<Player>();
            Console.WriteLine("Введи кол-во игроков");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            string[] names = { "player1", "player2", "player3", "player4", "player5", "player6", "player7", "player8", "player9", "player10", "player11", "player12", "player13", "player14", "player15", "player16" };
            if ((numberOfPlayers % 2 != 0) || (numberOfPlayers <= 0) || (numberOfPlayers > 16))
            {
                // Console.WriteLine("Вы ввели некоректное кол-во игроков");
                throw new ArgumentOutOfRangeException("incorect number of players");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Team1");
            for (int i = 0; i < numberOfPlayers / 2; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 3);
                if (a == 0)
                {
                    team1.Add(new Knight(names[i]));
                    Console.WriteLine("Player number: {0}, named: {1}, take a character: Knight", i + 1, names[i]);
                }

                if (a == 1)
                {
                    team1.Add(new Archer());
                    Console.WriteLine("Player number: {0}, named: {1}, take a character: Archer", i + 1, names[i]);
                }

                if (a == 2)
                {
                    team1.Add(new Mage());
                    Console.WriteLine("Player number: {0}, named: {1}, take a character: Mage", i + 1, names[i]);
                }
            }

            Console.WriteLine("Team2");
            for (int i = numberOfPlayers / 2; i < numberOfPlayers; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 3);
                if (a == 0)
                {
                    team2.Add(new Knight(names[i], team1[i - (numberOfPlayers / 2)]));
                    Console.WriteLine("Player number: {0}, named: {1}, take a character: Knight", i + 1, names[i]);
                }

                if (a == 1)
                {
                    team2.Add(new Archer(names[i], team1[i - (numberOfPlayers / 2)]));
                    Console.WriteLine("Player number: {0}, named: {1}, take a character: Archer", i + 1, names[i]);
                }

                if (a == 2)
                {
                    team2.Add(new Mage(names[i], team1[i - (numberOfPlayers / 2)]));
                    Console.WriteLine("Player number: {0}, named: {1}, take a character: Mage", i + 1, names[i]);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Team1 vs Team2");

            for (int i = 0; i < numberOfPlayers / 2; i++)
            {
                team1[i].Enemy = team2[i];

                // Console.WriteLine(team1[i].Enemy);
                Console.Write(team1[i]);
                Console.Write(" vs ");
                Console.WriteLine(team2[i]);
            }

            Console.WriteLine(" ");

            for (int i = 0; i < numberOfPlayers / 2; i++)
            {
                Console.Write(team1[i]);
                Console.Write(" vs ");
                Console.WriteLine(team2[i]);
                Fight(team1[i]);
            }

            if (team1Points > team2Points)
            {
                Console.WriteLine("team1 win");
            }

            if (team2Points > team1Points)
            {
                Console.WriteLine("team2 win");
            }

            if (team2Points == team1Points)
            {
                Console.WriteLine("draw");
            }
        }

        private static void Fight(Player player)
        {
            int turnNumber = 1;
            int cooldownTeam1 = 0;
            int cooldownTeam2 = 0;
            Random rnd = new Random();
            Console.WriteLine(" ");
            Console.WriteLine("{0} have {1}, his strong: {2}", player, player.HP, player.Strong);
            Console.WriteLine("{0} have {1}, his strong: {2}", player.Enemy, player.Enemy.HP, player.Enemy.Strong);
            while (player.HP > 0 && player.Enemy.HP > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("round {0}", turnNumber);
                Console.WriteLine(" ");

                turnNumber++;

                Random b = new Random();
                var arr1 = new[] { 0, 1 };
                var rndMember = arr1[b.Next(arr1.Length)];

                // int cooldown=0;

                // Console.WriteLine("rndMember={0}", rndMember);
                if (player.Effects.Contains("Freezing"))
                {
                    Console.WriteLine("{0} skip tyrn because of Freezing", player);
                }
                else
                {
                    if (player.Effects.Contains("Fire arrows"))
                    {
                        player.HP = player.HP - 2;
                        if (player.HP > 0)
                        {
                            Console.WriteLine("{0} take 2 damage from Fire arrows, his HP {1}", player, player.HP);
                        }

                        if (player.HP < 0)
                        {
                            team2Points = team2Points + 1;
                            player.HP = 0;
                            Console.WriteLine("{0} take 2 damage from Fire arrows, his HP {1}", player, player.HP);
                            Console.WriteLine("{0} have {1}", player.Enemy, player.Enemy.HP);
                            Console.WriteLine("{0}, win", player.Enemy);
                            Console.WriteLine(" ");
                            team2Points++;
                            break;
                        }
                    }
                    else
                    {
                        if ((rndMember != 0) && (cooldownTeam1 != 3))
                        {
                            if (player.ToString() == "RPG.Knight")
                            {
                                Console.WriteLine("{0} use his ultimate Abilitiy and given damage equal 130% of his strong: {1}", player, player.Strong * 1.3);
                                player.Enemy.HP = player.Enemy.HP - (player.Strong * 1.3);
                                cooldownTeam1 = 3;
                            }

                            if (player.ToString() == "RPG.Mage")
                            {
                                Console.WriteLine("{0} use his ultimate Abilitiy skipping turn on: {1}", player, player.Enemy);
                                player.Enemy.Effects.Add("Freezing");
                                cooldownTeam1 = 3;
                            }

                            if (player.ToString() == "RPG.Archer")
                            {
                                Console.WriteLine("{0} use his ultimate Abilitiy Fire arrows on: {1}", player, player.Enemy);
                                player.Enemy.Effects.Add("Fire arrows");
                                cooldownTeam1 = 3;
                            }
                        }
                        else
                        {
                            player.Enemy.HP = player.Enemy.HP - player.Strong;
                            Console.WriteLine("{0} deal damage to {1} : {2}", player, player.Enemy, player.Strong);

                            // if (cooldown == 0) { cooldown = 0; }
                            if ((cooldownTeam1 > 0) && (cooldownTeam1 < 4))
                            {
                                cooldownTeam1--;
                            }
                        }
                    }
                }

                // Console.WriteLine("{0} deal damage to {1} : {2}", player, player.Enemy, player.Strong);
                if (player.Enemy.HP < 0)
                {
                    team1Points = team1Points + 1;
                    player.Enemy.HP = 0;
                    Console.WriteLine("{0} have {1}", player, player.HP);
                    Console.WriteLine("{0} have {1}", player.Enemy, player.Enemy.HP);
                    Console.WriteLine("{0}, win", player);
                    Console.WriteLine(" ");
                    team1Points++;
                    break;
                }
                else
                {
                    Console.WriteLine("{0} have {1}", player, player.HP);
                    Console.WriteLine("{0} have {1}", player.Enemy, player.Enemy.HP);
                }

                Console.WriteLine(" ");

                /*if (player.Enemy.HP > 0)
                {
                    Console.WriteLine("{0} deal damage to {1} : {2}", player.Enemy, player, player.Enemy.Strong);
                    // player.Enemy.Ability();
                    player.HP = player.HP - player.Enemy.Strong;
                }*/

                if (player.Enemy.HP > 0)
                {
                    if (player.Enemy.Effects.Contains("Freezing"))
                    {
                        Console.WriteLine("{0} skip tyrn because of Freezing", player.Enemy);
                    }
                    else
                    {
                        if (player.Enemy.Effects.Contains("Fire arrows"))
                        {
                            player.Enemy.HP = player.Enemy.HP - 2;
                            if (player.Enemy.HP > 0)
                            {
                                Console.WriteLine("{0} take 2 damage from Fire arrows, his HP {1}", player.Enemy, player.Enemy.HP);
                            }

                            if (player.Enemy.HP < 0)
                            {
                                team1Points = team1Points + 1;
                                player.Enemy.HP = 0;
                                Console.WriteLine("{0} take 2 damage from Fire arrows, his HP {1}", player.Enemy, player.Enemy.HP);
                                Console.WriteLine("{0} have {1}", player, player.HP);
                                Console.WriteLine("{0}, win", player);
                                Console.WriteLine(" ");
                                team1Points++;
                                break;
                            }
                        }
                        else
                        {
                            if ((rndMember != 0) && (cooldownTeam2 != 3))
                            {
                                if (player.ToString() == "RPG.Knight")
                                {
                                    Console.WriteLine("{0} use his ultimate Abilitiy and given damage equal 130% of his strong: {1}", player.Enemy, player.Enemy.Strong * 1.3);
                                    player.HP = player.HP - (player.Enemy.Strong * 1.3);
                                    cooldownTeam2 = 3;
                                }

                                if (player.ToString() == "RPG.Mage")
                                {
                                    Console.WriteLine("{0} use his ultimate Abilitiy skipping turn on: {1}", player.Enemy, player);
                                    player.Effects.Add("Freezing");
                                    cooldownTeam2 = 3;
                                }

                                if (player.ToString() == "RPG.Archer")
                                {
                                    Console.WriteLine("{0} use his ultimate Abilitiy Fire arrows on: {1}", player, player.Enemy);
                                    player.Effects.Add("Fire arrows");
                                    cooldownTeam2 = 3;
                                }
                            }
                            else
                            {
                                player.HP = player.HP - player.Strong;
                                Console.WriteLine("{0} deal damage to {1} : {2}", player.Enemy, player, player.Enemy.Strong);

                                // if (cooldown == 0) { cooldown = 0; }
                                if ((cooldownTeam2 > 0) && (cooldownTeam2 < 4))
                                {
                                    cooldownTeam2--;
                                }
                            }
                        }
                    }
                }

                if (player.HP < 0)
                {
                    player.HP = 0;
                    Console.WriteLine("{0} have {1}", player, player.HP);
                    Console.WriteLine("{0} have {1}", player.Enemy, player.Enemy.HP);
                    Console.WriteLine("{0}, win", player.Enemy);
                    Console.WriteLine(" ");
                    team2Points++;
                    break;
                }
                else
                {
                     Console.WriteLine("{0} have {1}", player, player.HP);
                     Console.WriteLine("{0} have {1}", player.Enemy, player.Enemy.HP);
                }

                Console.WriteLine(" ");
            }
        }
    }
}
