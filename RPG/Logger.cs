using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public static class Logger
    {
        public static void LUseAbility(Player player)
        {
            Console.WriteLine(player.ToString(), "{ 0} use his ultimate Abilitiy");
        }
        public static void LTakeDamage(Player player, float damage)
        {
            Console.WriteLine(player.Enemy.ToString(), player.ToString(), damage, "{0}, take damage from {1} equal {2}");
        }
    }
}
