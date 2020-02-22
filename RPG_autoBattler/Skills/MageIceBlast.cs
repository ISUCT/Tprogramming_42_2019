using System;

namespace RPG_autoBattler
{
    public class MageIceBlast : ISpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public int StunDuration { get; set; }

        public float DamageReducted { get; set; }

        public bool IsPassive { get; set; }

        public bool IsRanged { get; set; }

        public void Cast(Char caster, Char victim)
        {
            Console.WriteLine($"{victim} is frozen for {StunDuration} turn(s)!");
            victim.TakeDamage(caster, caster.Intelligence - DamageReducted);
            victim.StunTimer += StunDuration;
        }

        public void Trigger(string s, Char a, Char b, float[] f)
        {
        }
    }
}
