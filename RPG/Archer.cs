using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Archer : Player
    {
        public Archer()
        : this("Неизвестно")
        {
        }
        public Archer(string name)
        : this(name, null)
        {
        }
        public Archer(string name, Player enemy)
        : base(name, enemy)
        {
            Class = "Archer";
            UseAbility.Add(new ArcherAbility());
        }
    }
}