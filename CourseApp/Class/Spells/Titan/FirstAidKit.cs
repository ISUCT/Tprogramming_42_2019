using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class FirstAidKit : ISpell
    {
        public string Name { get; set; }

        public void Use(Player caster, Player target)
        {
            if ((caster.CurrentHp + 5) < caster.PlayerMaxHp)
            {
                caster.CurrentHp = caster.CurrentHp + 5;
            }
            else
            {
                Console.WriteLine("HP is FULL");
            }

            if (caster.CurrentHp > caster.PlayerMaxHp)
            {
                caster.CurrentHp = caster.PlayerMaxHp;
            }
        }
    }
}
