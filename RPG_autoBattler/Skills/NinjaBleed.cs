using System;

namespace RPG_autoBattler
{
    public class NinjaBleed : ISpell, IPassiveSpell
    {
        public string Name { get; set; }

        public int Lvl { get; set; }

        public int TurnsLeft { get; set; }

        public float DamagePercent { get; set; }

        public bool IsPassive { get; set; }

        public int StunDuration { get; set; }

        public bool IsRanged { get; set; }

        public void Trigger(string triggerType, Character attacker, Character victim, float[] specValue)
        {
            if (triggerType == "DealDamage")
            {
                NinjaBleedEffect bleed = new NinjaBleedEffect();
                bleed.TurnsLeft = TurnsLeft;
                bleed.DamagePercent = DamagePercent;
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
