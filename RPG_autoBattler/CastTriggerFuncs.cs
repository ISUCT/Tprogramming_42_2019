using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public static class CastTriggerFuncs
    {
        public static void BaseAttackFunc(Char caster, Char victim, float[] specVal)
        {
            victim.TakeDamage(caster, caster.Agi);
        }

        public static void HammerStrikeFunc(Char caster, Char victim, float[] specVal)
        {
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is stunned for {(int)specVal[1]} turn(s)!");
            victim.TakeDamage(caster, caster.Agi);
            victim.StunTimer += (int)specVal[1];
        }

        public static void ShurikensFunc(Char caster, Char victim, float[] specVal)
        {
            for (int i = 0; i < specVal[1]; i++)
            {
                victim.TakeDamage(caster, specVal[0]);
            }
        }

        public static void PierceFunc(Char caster, Char victim, float[] specVal)
        {
            victim.CurHP -= caster.Agi + specVal[0];
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) takes {caster.Agi + specVal[0]} damage! {victim.CurHP} HP left!");
        }

        public static void FireballFunc(Char caster, Char victim, float[] specVal)
        {
            victim.TakeDamage(caster, caster.Int);
            specVal[3] = specVal[2];
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is on fire for {specVal[3]} turns!");
        }

        public static void IceBlastFunc(Char caster, Char victim, float[] specVal)
        {
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is frozen for {(int)specVal[1]} turn(s)!");
            victim.TakeDamage(caster, caster.Int - specVal[0]);
            victim.StunTimer += (int)specVal[1];
        }

        public static void HealFunc(Char caster, Char victim, float[] specVal)
        {
            caster.Heal(specVal[0]);
            Console.WriteLine($"{caster.Name} {caster.Surname} ({caster.Class}) is healed by {specVal[0]}! {caster.CurHP} left!");
        }

        public static void FogFunc(Char caster, Char victim, float[] specVal)
        {
            specVal[0] = specVal[2];
            Console.WriteLine($"{caster.Name} {caster.Surname} ({caster.Class}) is hidden in the Smoke Screen for {specVal[0]} enemy turns!");
        }

        public static void MagicShieldFunc(Char caster, Char victim, float[] specVal)
        {
            specVal[1] = specVal[0];
            Console.WriteLine($"{caster.Name} {caster.Surname} ({caster.Class}) is protected from any attacks for {specVal[0]} enemy turns!");
        }

        public static void TrigEmpty(string triggerType, Char attacker, Char victim, float[] specVal, float[] innerVal)
        {
        }

        public static void CastEmpty(Char caster, Char victim, float[] specVal)
        {
        }

        public static void PalBlockTrig(string triggerType, Char attacker, Char victim, float[] specVal, float[] innerVal)
        {
            if (triggerType == "TakeDamage")
            {
                victim.CurHP -= specVal[0] * innerVal[0];
                throw new ProtectException($"{victim.Name} {victim.Surname} ({victim.Class}) takes {specVal[0] * innerVal[0]} damage! {victim.CurHP} HP left!");
            }
        }

        public static void FogTrig(string triggerType, Char attacker, Char victim, float[] specVal, float[] innerVal)
        {
            if (triggerType == "HitBySpell")
            {
                if ((int)innerVal[0] > 0)
                {
                    Random rnd = new Random();
                    if (rnd.Next(0, 100) < innerVal[1])
                    {
                        Console.WriteLine($"{attacker.Name} {attacker.Surname} ({attacker.Class}) tries to attack!");
                        throw new ProtectException($"Miss! {victim.Name} {victim.Surname} ({victim.Class}) hides in the smoke screen and takes no damage!");
                    }
                }
            }

            if ((triggerType == "TurnEnd") && ((int)specVal[0] == 1))
            {
                innerVal[0]--;
            }

            if (triggerType == "BattleEnd")
            {
                innerVal[0] = 0;
            }
        }

        public static void FireTrig(string triggerType, Char attacker, Char victim, float[] specVal, float[] innerVal)
        {
            if ((triggerType == "TurnEnd") && ((int)specVal[0] == 1) && ((int)innerVal[3] > 0))
            {
                Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is on fire!");
                victim.TakeDamage(attacker, innerVal[1]);
                innerVal[3]--;
            }

            if (triggerType == "BattleEnd")
            {
                innerVal[3] = 0;
            }
        }

        public static void MageShieldTrig(string triggerType, Char attacker, Char victim, float[] specVal, float[] innerVal)
        {
            if (triggerType == "HitBySpell")
            {
                if ((int)innerVal[1] > 0)
                {
                    Console.WriteLine($"{attacker.Name} {attacker.Surname} ({attacker.Class}) tries to attack!");
                    throw new ProtectException($"Wow! Magic Shield of {victim.Name} {victim.Surname} ({victim.Class}) absorbs all incoming damage! No damage taken!");
                }
            }

            if ((triggerType == "TurnEnd") && ((int)specVal[0] == 1))
            {
                innerVal[1]--;
            }

            if (triggerType == "BattleEnd")
            {
                innerVal[1] = 0;
            }
        }
    }
}
