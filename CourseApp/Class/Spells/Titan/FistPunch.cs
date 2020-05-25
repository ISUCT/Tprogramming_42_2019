using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class FistPunch : ISpell
    {
        public string Name { get; set; }

        public void Use(Player caster, Player target)
        {
            target.CurrentHp = target.CurrentHp - (10 * (caster.Agility / 2));
        }
    }
}