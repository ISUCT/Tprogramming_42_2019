using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class GrenadeThrow : ISpell
    {
        public string Name { get; set; }

        public void Use(Player caster, Player target)
        {
            target.GetDamage(15 * (caster.Strength / 2));
        }
    }
}
