using System;

namespace RPG
{
    public class Knight : Hero
    {
        Random random = new Random();

        public Knight()
        : base()
        {
            heroClass = "Knight";
            skillName = "Retaliation strike";
        }

        public override int Skill()
        {
            return (int)Math.Floor(Strength * 1.5);
        }
    }
}
