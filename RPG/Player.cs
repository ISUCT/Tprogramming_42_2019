using System;
using System.Collections.Generic;
using System.Linq;


namespace RPG
{
    public abstract class Player
    {
        private static readonly Random rnd = new Random();
        public Player()
        : this("Неизвестно")
        {
        }
        public Player(string name)
        : this(name, null)
        {
        }
        public Player(string name, Player enemy)
        {
            Name = name;
            Enemy = enemy;
            UseAbility.Add(new Attack());
        }
        public string Class { get; protected set; }
        public string Name { get; set; }
        public Player Enemy { get; set; } = null;
        public double HP { get; set; } = rnd.Next(1, 100);
        public int Strong { get; } = rnd.Next(1, 99);
        public Abilities UsingAbility { get; set; }

        public List<Abilities> UseAbility = new List<Abilities>();
        public List<string> Effects = new List<string>();
        public void Ability()
        {
            if (!Effects.Contains("Freezing"))
            {
                if (!Effects.Contains("Fire arrows"))
                {
                    UsingAbility.Ability(this);
                }
                else
                {
                    HP = HP - 2;
                    Console.WriteLine("Player: {Name}, Class: {Class} take 2 damage from fire arrows");
                    UsingAbility.Ability(this);
                }
            }
            else
            {
                Console.WriteLine("Player: {Name}, Class{Class} skip pass");
                Effects.Remove("Freezing");
            }
        }

    }
}
