using System;

namespace RPG_autoBattler
{
    public class MageFireball : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public float Damage { get; set; }

        public float TickDamage { get; set; }

        public int TickDuration { get; set; }

        public bool IsPassive { get; set; }

        public bool IsRanged { get; set; }

        public void Cast(Character caster, Character victim)
        {
            victim.TakeDamage(caster, caster.Intelligence);
            Burning burning = new Burning();
            burning.TurnsLeft = TickDuration;
            burning.Damage = TickDamage;
            victim.Effects.Add(burning);
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is on fire for {TickDuration} turns!");
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
