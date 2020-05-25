using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public interface IEffects
    {
        string Name { get; set; }

        int Duration { get; set; }

        void Heal(Player target);

        void Damage(Player target);

        void Boost(Player target);
    }
}
