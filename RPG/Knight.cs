using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Knight : Player
    {
        public Knight()
        : this("Неизвестно")
        {
        }
        public Knight(string name)
        : this(name, null)
        {
        }
        public Knight(string name, Player enemy)
        : base(name, enemy)
        {
            Class = "Knight";
            UseAbility.Add(new KnightAbility());
        }
    }
}
