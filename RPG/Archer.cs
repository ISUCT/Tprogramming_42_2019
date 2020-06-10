using System;

namespace RPG
{
    public class Archer : Hero
    {
        Random random = new Random();

        public Archer()
        : base()
        {
            heroClass = "Archer";
            skillName = "Fire arrows";
        }

        public override int Skill()
        {
            bufName = "Fire arrows";
            buf = true;
            bufDamage = 5;
            return 0;
        }
    }
}
