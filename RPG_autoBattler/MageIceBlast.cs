using System;

namespace RPG_autoBattler
{
    public class MageIceBlast : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        public int StunDuration { get; set; }

        public float DamageReducted { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            Console.WriteLine($"{victim} is frozen for {StunDuration} turn(s)!");
            victim.TakeDamage(caster, caster.Intelligence - DamageReducted);
            victim.StunTimer += StunDuration;
        }
    }
}
