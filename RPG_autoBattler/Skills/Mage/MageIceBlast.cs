using System;

namespace RpgAutoBattler
{
    public class MageIceBlast : ISpell
    {
        public string Name { get; set; } = "Ice Blast";

        public int Lvl { get; set; }

        public int StunDuration { get; set; }

        public float DamageReducted { get; set; }

        public bool IsPassive { get; set; } = false;

        public bool IsRanged { get; set; } = true;

        public void Cast(Character caster, Character victim)
        {
            Console.WriteLine($"{victim} is frozen for {StunDuration} turn(s)!");
            victim.TakeDamage(caster, caster.Intelligence - DamageReducted);
            victim.StunTimer += StunDuration;
        }

        public void Trigger(TriggerType s, Character a, Character b, float[] f)
        {
        }
    }
}
