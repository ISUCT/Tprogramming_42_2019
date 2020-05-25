using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class VoidBlast : ISpell
    {
        public string Name { get; set; }

        public void Use(Player caster, Player target)
        {
            target.GetDamage(15 * (caster.Intelligence / 2));
        }
    }
}
