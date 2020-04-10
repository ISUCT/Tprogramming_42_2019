using System;

namespace RpgAutoBattler
{
    public class NinjaBleed : ISpell, IPassiveSpell
    {
        public string Name { get; set; } = "Sharp blades";

        public int Lvl { get; set; }

        public int TurnsLeft { get; set; }

        public float DamagePercent { get; set; }

        public bool IsPassive { get; set; } = true;

        public int StunDuration { get; set; }

        public bool IsRanged { get; set; } = false;

        public void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == TriggerType.DealDamage)
            {
                NinjaBleedEffect bleed = new NinjaBleedEffect
                {
                    TurnsLeft = TurnsLeft,
                    DamagePercent = DamagePercent
                };
                bool isFoundAlready = false;
                for (int i = 0; i < victim.Effects.Count; i++)
                {
                    if (victim.Effects[i] is NinjaBleedEffect)
                    {
                        isFoundAlready = true;
                        victim.Effects[i].TurnsLeft = TurnsLeft;
                    }
                }

                if (isFoundAlready == false)
                {
                    victim.Effects.Add(bleed);
                }

                Console.WriteLine($"{victim} is now bleeding for {TurnsLeft} more turns!");
            }
        }

        public void Cast(Character caster, Character victim)
        {
        }
    }
}
