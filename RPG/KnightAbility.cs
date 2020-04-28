using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class KnightAbility : Abilities
    {
        public void Ability (Player player)
        {
            player.Enemy.HP = player.Enemy.HP - player.Strong* 1.3;
            Console.WriteLine("Player: {player.Class} use retaliation strike and deal damage {plyer.Strong * 1.3} to {player.Enemy.Class}, {player.Enemy.Name}");
        }
    }
}
