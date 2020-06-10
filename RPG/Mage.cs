using System;

namespace RPG
{
    public class Mage : Hero
    {
        Random random = new Random();

        public Mage()
        : base()
        {
            heroClass = "Mage";
            skillName = "Fascination";
        }

        public override int Skill()
        {
            
            sleepTime = 2;
            return 0;
        }
    }
}
