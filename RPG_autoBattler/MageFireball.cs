using System;

namespace RPG_autoBattler
{
    public class MageFireball : ISpell, IActiveSpell
    {
        string ISpell.Name { get; set; }

        int ISpell.Lvl { get; set; }

        public float Damage { get; set; }

        public float TickDamage { get; set; }

        public int TickDuration { get; set; }

        bool IActiveSpell.IsRanged { get; set; }

        void IActiveSpell.Cast(Char caster, Char victim)
        {
            victim.TakeDamage(caster, caster.Intelligence);
            Burning burning = new Burning();
            burning.TurnsLeft = TickDuration;
            burning.Damage = TickDamage;
            victim.Effects.Add(burning);
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is on fire for {TickDuration} turns!");
        }
    }
}
