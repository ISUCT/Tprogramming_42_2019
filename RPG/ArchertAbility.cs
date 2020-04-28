using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class ArcherAbility : Abilities
    {
        public void Ability(Player player)
        {
            player.Enemy.Effects.Add("Fire arrows");
            Console.WriteLine("Player: {player.Class} use Fire arrows to {player.Enemy.Class}, {player.Enemy.Name}");
        }
    }
}