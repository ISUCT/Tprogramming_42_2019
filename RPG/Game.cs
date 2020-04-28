using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    public enum CharacterClass
    {
        Knight,
        Archer,
        Mage
    }

    public enum CharacterAbilities
    {
        Freezing, //заморозка
        Fire_arrows, //огненные стрелы
        Сritical_damage //критический урон
    }
    public class Game
    {
        private static int EnemyNumber;
        private static double T1HP = 0;
        private static double T2HP = 0;
        private static double TeamAlive1(int numberOfPlayers, List<Player> team1)
        {
                T1HP = 0;
                for (int i = 0; i < numberOfPlayers / 2; i++)
                {
                //Console.WriteLine("team1: {0} , his HP{1}", team1[i], team1[i].HP);
                T1HP = T1HP + team1[i].HP;
                }
                return T1HP;
        }
        private static double TeamAlive2 (int numberOfPlayers, List<Player> team2)
        {
             T2HP = 0;
             for (int i = numberOfPlayers / 2; i < numberOfPlayers; i++)
             {
                //double T2HP;
                /*Console.WriteLine(T2HP);
                Console.WriteLine(team2[i-6]);
                Console.WriteLine(team2[i-6].HP);*/
                T2HP = T2HP + team2[i- numberOfPlayers / 2].HP;
             }
             return T2HP;
        }

        private static void PickPlayer(int numberOfPlayers, List<Player> team1, List<Player> team2)
        {

            string[] names = { "player1", "player2", "player3", "player4", "player5", "player6", "player7", "player8", "player9", "player10", "player11", "player12", "player13", "player14", "player15", "player16" };
            if ((numberOfPlayers % 2 != 0) || (numberOfPlayers <= 0) || (numberOfPlayers > 16))
            {
                throw new ArgumentOutOfRangeException("incorect number of players");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Team1");
            for (int i = 0; i < numberOfPlayers / 2; i++)
            {
                CharacterClass  yourPlayerClass = (CharacterClass)(new Random()).Next(0, 3);
                switch (yourPlayerClass)
                {
                    case CharacterClass.Knight:
                        team1.Add(new Knight(names[i]));
                        Console.WriteLine("Player number: {0}, named: {1}, take a character: Knight", i + 1, names[i]);
                        Console.WriteLine("HIS HP: {0} HIS STRONG {1}", team1[i].HP, team1[i].Strong);
                        break;
                    case CharacterClass.Archer:
                        team1.Add(new Archer(names[i]));
                        Console.WriteLine("Player number: {0}, named: {1}, take a character: Archer", i + 1, names[i]);
                        Console.WriteLine("HIS HP: {0} HIS STRONG {1}", team1[i].HP, team1[i].Strong);
                        break;
                    case CharacterClass.Mage:
                        team1.Add(new Mage(names[i]));
                        Console.WriteLine("Player number: {0}, named: {1}, take a character: Mage", i + 1, names[i]);
                        Console.WriteLine("HIS HP: {0} HIS STRONG {1}", team1[i].HP, team1[i].Strong);
                        break;
                }
            }

            Console.WriteLine("Team2");
            for (int i = numberOfPlayers / 2; i < numberOfPlayers; i++)
            {
                CharacterClass yourPlayerClass = (CharacterClass)(new Random()).Next(0, 3);
                switch (yourPlayerClass)
                {
                    case CharacterClass.Knight:
                        team2.Add(new Knight(names[i]));
                        Console.WriteLine("Player number: {0}, named: {1}, take a character: Knight", i + 1, names[i]);
                        Console.WriteLine("HIS HP: {0}, HIS STRONG {1}", team2[i- numberOfPlayers/2].HP, team2[i- numberOfPlayers / 2].Strong);
                        break;
                    case CharacterClass.Archer:
                        team2.Add(new Archer(names[i]));
                        Console.WriteLine("Player number: {0}, named: {1}, take a character: Archer", i + 1, names[i]);
                        Console.WriteLine("HIS HP: {0} HIS STRONG {1}", team2[i - numberOfPlayers / 2].HP, team2[i- numberOfPlayers / 2].Strong);
                        break;
                    case CharacterClass.Mage:
                        team2.Add(new Mage(names[i]));
                        Console.WriteLine("Player number: {0}, named: {1}, take a character: Mage", i + 1, names[i]);
                        Console.WriteLine("HIS HP: {0}  HIS STRONG {1}", team2[i - numberOfPlayers / 2].HP, team2[i- numberOfPlayers / 2].Strong);
                        break;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Team1 vs Team2");

            for (int i = 0; i < numberOfPlayers / 2; i++)
            {
                Console.Write(team1[i]);
                Console.Write(" vs ");
                Console.WriteLine(team2[i]);
            }

        }
        static void Main(string[] args)
        {
            int turn_number=1;
            List<Player> team1 = new List<Player>();
            List<Player> team2 = new List<Player>();
            Console.WriteLine("Введи кол-во игроков");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            int[] cooldown = new int[numberOfPlayers];
            PickPlayer(numberOfPlayers, team1, team2);

            Console.WriteLine(" ");
            for (int i = 0; i < numberOfPlayers; i++)
            {
                cooldown[i] = 0;
            }

            while ((TeamAlive1(numberOfPlayers, team1) > 0) && (TeamAlive2(numberOfPlayers, team2)>0))
            {
                Console.WriteLine("turn number: {0}", turn_number);
                Console.WriteLine(" ");
                Console.WriteLine("{0}+{1}+{2}+{3}+{4}+{5}= ", team1[0].HP, team1[1].HP, team1[2].HP, team1[3].HP, team1[4].HP, team1[5].HP);
                Console.Write("HPTeam1: {0}", TeamAlive1(numberOfPlayers, team1));
                Console.WriteLine(" ");
                Console.WriteLine("HPTeam2: {0}", TeamAlive2(numberOfPlayers, team2));
                Console.WriteLine(" ");
                for (int i = 0; i < numberOfPlayers / 2; i++)
                {
                    Random rnd = new Random();
                    int enemyNumber = rnd.Next(0, numberOfPlayers/2);
                    if (team1[i].HP > 0)
                    {
                        Fight(team1[i], enemyNumber, cooldown[i], 1, team1, team2);
                    }
                    else
                    {
                        Console.WriteLine("You are dead");
                    }
                }
                for (int i = numberOfPlayers / 2 + 1 ; i < numberOfPlayers; i++)
                {
                    Random rnd = new Random();
                    int enemyNumber = rnd.Next(0, numberOfPlayers / 2);
                    if (team2[i- numberOfPlayers / 2].HP > 0)
                    {
                        Fight(team2[i- numberOfPlayers / 2], enemyNumber, cooldown[i], 2, team1, team2);
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine("Оставшееся здоровье у героев после раунда {0}", turn_number);
                for (int i = 0; i < numberOfPlayers / 2; i++)
                {
                    Console.WriteLine("player number {0} named {1}, have {2} ", i, team1[i], team1[i].HP);
                }
                for (int i = numberOfPlayers / 2; i < numberOfPlayers; i++)
                {
                    Console.WriteLine("player number {0} named {1}, have {2} ", i, team2[i - numberOfPlayers / 2], team2[i - numberOfPlayers / 2].HP);
                }
                turn_number++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Оставшееся здоровье у героев");

            for (int i = 0; i < numberOfPlayers/2; i++)
            {
                Console.WriteLine("player number {0} named {1}, have {2} ",i,team1[i], team1[i].HP);
            }

            for (int i = numberOfPlayers / 2; i < numberOfPlayers; i++)
            {
                Console.WriteLine("player number {0} named {1}, have {2} ", i, team2[i- numberOfPlayers / 2], team2[i- numberOfPlayers / 2].HP);
            }

            if (TeamAlive1(numberOfPlayers, team1) == 0)
            {
                Console.WriteLine("Team2 win");
            }
            else
            {
                Console.WriteLine("Team1 win");
            }

        }

        private static void Fight(Player player, int enemyNumber, int kd, int TeamTurn, List<Player> team1, List<Player> team2)
        {
            Random rnd = new Random();
            Random b = new Random();
            var arr1 = new[] { 0, 1 };
            var rndMember = arr1[b.Next(arr1.Length)];
            int turnNumber = 1;
            int TT = TeamTurn;

            if (TT == 1)
            {
                player.Enemy = team2[enemyNumber];
            }
            else
            {
                player.Enemy = team1[enemyNumber];
            }
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
                        player.HP = 0;
                        Console.WriteLine("{0} take 2 damage from Fire arrows, his HP {1}", player, player.HP);
                        Console.WriteLine("{0} have {1}", player.Enemy, player.Enemy.HP);
                        Console.WriteLine(" ");
                        //goto link1;
                        return ;
                    }
                }
                else
                {
                    if ((rndMember != 0) && (kd != 3))
                    {
                        if (player.ToString() == "RPG.Knight")
                        {
                            
                            Console.WriteLine("{0} use his ultimate Abilitiy and given damage equal 130% of his strong: {1}", player, player.Strong * 1.3);
                            player.Enemy.HP = player.Enemy.HP - (player.Strong * 1.3);
                            if (player.Enemy.HP <0)
                            {
                                player.Enemy.HP = 0;
                            }
                            kd = 3;
                        }

                        if (player.ToString() == "RPG.Mage")
                        {
                            Console.WriteLine("{0} use his ultimate Abilitiy skipping turn on: {1}", player, player.Enemy);
                            player.Enemy.Effects.Add("Freezing");
                            kd = 3;
                        }

                        if (player.ToString() == "RPG.Archer")
                        {
                            Console.WriteLine("{0} use his ultimate Abilitiy Fire arrows on: {1}", player, player.Enemy);
                            player.Enemy.Effects.Add("Fire arrows");
                            kd = 3;
                        }
                    }
                    else
                    {
                        player.Enemy.HP = player.Enemy.HP - player.Strong;
                        Console.WriteLine("{0} deal damage to {1} : {2}", player, player.Enemy, player.Strong);
                        if (player.Enemy.HP<0)
                        {
                            player.Enemy.HP = 0;
                        }
                        Console.WriteLine("{0} have {1} ", player.Enemy, player.Enemy.HP);

                        if ((kd > 0) && (kd < 4))
                        {
                            kd--;
                        }
                    }
                }
            }
        //link1:
            Console.WriteLine("  ");
            //turnNumber++;
        }

        /*private static void Fight(Player player, int enemyNumber)
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
        }*/

        /*private static void Fight(Player player)
        {
            int turnNumber = 1;
            int[] cooldown = new int[numberOfPlayers];
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
        }*/
    }
}
