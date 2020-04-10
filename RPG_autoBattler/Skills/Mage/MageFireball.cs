using System;

namespace RpgAutoBattler
{
    public class MageFireball : ISpell
    {
        public string Name { get; set; } = "Fireball Toss";

        public int Lvl { get; set; }

        public float Damage { get; set; }

        public float TickDamage { get; set; }

        public int TickDuration { get; set; }

        public bool IsPassive { get; set; } = false;

        public bool IsRanged { get; set; } = true;

        public void Cast(Character caster, Character victim)
        {
            victim.TakeDamage(caster, caster.Intelligence + Damage);
            Burning burning = new Burning
            {
                TurnsLeft = TickDuration,
                Damage = TickDamage
            };
            victim.Effects.Add(burning);
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is on fire for {TickDuration} turns!");
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
