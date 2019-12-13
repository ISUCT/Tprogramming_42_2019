using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public abstract class Char
    {
        private float maxhp;
        private float maxmp;
        private float curhp;
        private float curmp;
        private List<Spell> spells;

        public Char()
            {
                Lvl = 1;
            }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Str { get; set; }

        public int Agi { get; set; }

        public int Int { get; set; }

        public int Lvl { get; set; }
    }
}
