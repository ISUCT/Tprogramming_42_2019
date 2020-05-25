using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public interface ISpell
    {
        string Name { get; set; }

        void Use(Player caster, Player target);
    }
}
