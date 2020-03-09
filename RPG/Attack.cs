using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Attack : Abilities
    {
        public void Ability(Player player)
        {
            player.Enemy.HP = player.Enemy.HP - player.Strong;
        }
    }
}
