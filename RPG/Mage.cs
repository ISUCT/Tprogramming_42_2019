using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Mage : Player
    {
        public Mage()
        : this("Неизвестно")
        {
        }
        public Mage(string name)
        : this(name, null)
        {
        }
        public Mage(string name, Player enemy)
        : base(name, enemy)
        {
            Class = "Mage";
            UseAbility.Add(new MageAbility());
        }
    }
}