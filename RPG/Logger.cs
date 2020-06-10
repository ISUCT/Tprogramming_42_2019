using System;

namespace RPG
{
    class Logger
    {
        public void Atack(Hero hero1, Hero hero2, int damage)
        {
            Console.Write($"{hero1.Name} ({hero1.heroClass}) hit {hero2.Name} ({hero2.heroClass}) and deals {damage} damage");
            
            if(hero1.buf)
            {
                Console.WriteLine($" Additional damage of {hero1.bufDamage} units due to the amplification \"{hero1.bufName}\".");
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void Skill(Hero hero1, Hero hero2, string skillName, int damage)
        {
            if(hero1.sleepTime > 0 && damage == 0)
            {
                Console.WriteLine($"{hero1.Name} ({hero1.heroClass}) used skill \"{skillName}\" and stuns {hero2.Name} ({hero2.heroClass}) for {hero1.sleepTime} turns.");
            }
            else if(hero1.buf && damage == 0)
            {
                Console.WriteLine($"{hero1.Name} ({hero1.heroClass}) used buf \"{skillName}\"");
            }
            else
            {
                Console.Write($"{hero1.Name} ({hero1.heroClass}) used skill \"{skillName}\" and deals {hero2.Name} ({hero2.heroClass}) {damage} damage.");
                
                if(hero1.buf)
                {
                    Console.WriteLine($" Additional damage of {hero1.bufDamage} units due to the amplification \"{hero1.bufName}\".");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        
        public void Sleep(Hero hero)
        {
            Console.WriteLine($"{hero.Name} ({hero.heroClass}) stunned and skips turn.");
        }

        public void Win(Hero hero)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{hero.Name} ({hero.heroClass}) won!");
            Console.ResetColor();
        }

        public void Death(Hero hero)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{hero.Name} ({hero.heroClass}) is dead.\n");
            Console.ResetColor();
        }
    }
}
