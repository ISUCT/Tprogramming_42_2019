using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public class Game
    {
        private static List<Spell> palaSpells = new List<Spell>();
        private static List<Spell> ninjaSpells = new List<Spell>();
        private static List<Spell> mageSpells = new List<Spell>();

        public static int Battle(Char a, Char b)
        {
            Random rnd = new Random();
            int turn = 1;
            while ((a.CurHP > 0) && (b.CurHP > 0))
            {
                Console.Write($"Turn {turn}: ");
                if ((turn % 2) == 0)
                {
                    if (a.StunTimer == 0)
                    {
                        if (rnd.Next(0, 100) > 75)
                        {
                            int ran = rnd.Next(1, a.ActSpells.Count);

                            // Console.WriteLine($"Random = {ran}");
                            b.HitBySpell(a, a.ActSpells[ran]);
                        }
                        else
                        {
                            b.HitBySpell(a, a.ActSpells[0]);
                        }
                    }
                    else
                    {
                        a.StunTimer--;
                        Console.WriteLine($"{a.Name} {a.Surname} ({a.Class}) is stunned! {a.StunTimer} turn(s) left.");
                    }

                    foreach (Spell item in a.PasSpells)
                    {
                        item.Trigger("TurnEnd", a, b, new float[1] { 0 });
                    }

                    foreach (Spell item in b.PasSpells)
                    {
                        item.Trigger("TurnEnd", a, b, new float[1] { 1 });
                    }
                }
                else
                {
                    if (b.StunTimer == 0)
                    {
                        if (rnd.Next(0, 100) > 75)
                        {
                            int ran = rnd.Next(1, b.ActSpells.Count);

                            // Console.WriteLine($"Random = {ran}");
                            a.HitBySpell(b, b.ActSpells[ran]);
                        }
                        else
                        {
                            a.HitBySpell(b, b.ActSpells[0]);
                        }
                    }
                    else
                    {
                        b.StunTimer--;
                        Console.WriteLine($"{b.Name} {b.Surname} ({b.Class}) is stunned! {b.StunTimer} turn(s) left.");
                    }

                    foreach (Spell item in b.PasSpells)
                    {
                        item.Trigger("TurnEnd", a, b, new float[1] { 0 });
                    }

                    foreach (Spell item in a.PasSpells)
                    {
                        item.Trigger("TurnEnd", a, b, new float[1] { 1 });
                    }
                }

                turn++;
            }

            if (a.CurHP > 0)
            {
                Console.WriteLine($"{a.Name} {a.Surname} ({a.Class}) wins!");
                a.Heal(a.MaxHP);
                return 0;
            }
            else
            {
                Console.WriteLine($"{b.Name} {b.Surname} ({b.Class}) wins!");
                b.Heal(b.MaxHP);
                return 1;
            }
        }

        public static void Main()
        {
            palaSpells = RetPalSpells();
            ninjaSpells = RetNinjaSpells();

            // palSpells.Add(palBaseAttack);
            Console.WriteLine("Welcome to the Battle for Glory Arena. Press any key to start");
            Console.ReadKey();
            Console.WriteLine("Choose your class, type 'Paladin', 'Ninja' or 'Mage' here: ");
            string playerClass = Console.ReadLine();
            while ((playerClass != "Paladin") && (playerClass != "Ninja") && (playerClass != "Mage"))
            {
                Console.WriteLine("Error recognizing class, try to write again or copy and paste class name here: ");
                playerClass = Console.ReadLine();
            }

            Char player = new Char();
            player.Class = playerClass;
            player.CurHP = 70;
            player.MaxHP = 70;
            player.ActSpells.Add(palaSpells[0]);
            player.ActSpells.Add(palaSpells[1]);
            player.PasSpells.Add(palaSpells[2]);
            player.ActSpells.Add(palaSpells[3]);
            player.Name = "Arthas";
            player.Surname = "Menethil";
            Char vict = new Char();
            vict.Class = "Ninja";
            vict.ActSpells.Add(ninjaSpells[0]);
            vict.ActSpells.Add(ninjaSpells[1]);
            vict.ActSpells.Add(ninjaSpells[2]);
            vict.PasSpells.Add(ninjaSpells[2]);
            vict.ActSpells.Add(ninjaSpells[3]);
            vict.Name = "Mikey";
            vict.Surname = "Splinterson";
            vict.CurHP = 45;
            vict.MaxHP = 45;
            Battle(player, vict);
            /*Console.WriteLine($"Victim has {vict.CurHP} HP");
            vict.HitBySpell(player, player.Spells[0]);
            Console.WriteLine($"And now he has {vict.CurHP} HP");*/
            Console.ReadKey();
        }

        public static void BaseAttackFunc(Char caster, Char victim, ref float[] specVal)
        {
            victim.TakeDamage(caster, specVal[0]);
        }

        public static void HammerStrikeFunc(Char caster, Char victim, ref float[] specVal)
        {
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is stunned for {(int)specVal[1]} turn(s)!");
            victim.TakeDamage(caster, specVal[0]);
            victim.StunTimer += (int)specVal[1];
        }

        public static void ShurikensFunc(Char caster, Char victim, ref float[] specVal)
        {
            for (int i = 0; i < specVal[1]; i++)
            {
                victim.TakeDamage(caster, specVal[0]);
            }
        }

        public static void PierceFunc(Char caster, Char victim, ref float[] specVal)
        {
            victim.CurHP -= specVal[0];
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) takes {specVal[0]} damage! {victim.CurHP} HP left!");
        }

        public static void FireballFunc(Char caster, Char victim, ref float[] specVal)
        {
            victim.TakeDamage(caster, specVal[0]);
            specVal[3] = specVal[2];
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is on fire for {specVal[3]} turns!");
        }

        public static void HealFunc(Char caster, Char victim, ref float[] specVal)
        {
            caster.Heal(specVal[0]);
            Console.WriteLine($"{caster.Name} {caster.Surname} ({caster.Class}) is healed by {specVal[0]}! {caster.CurHP} left!");
        }

        public static void FogFunc(Char caster, Char victim, ref float[] specVal)
        {
            specVal[0] = specVal[2];
            Console.WriteLine($"{caster.Name} {caster.Surname} ({caster.Class}) is hidden in the Smoke Screen for {specVal[0]} enemy turns!");
        }

        public static void TrigEmpty(string triggerType, Char attacker, Char victim, float[] specVal, ref float[] innerVal)
        {
        }

        public static void CastEmpty(Char caster, Char victim, ref float[] specVal)
        {
        }

        public static void PalBlockTrig(string triggerType, Char attacker, Char victim, float[] specVal, ref float[] innerVal)
        {
            if (triggerType == "TakeDamage")
            {
                victim.CurHP -= specVal[0] * innerVal[0];
                throw new ProtectException($"{victim.Name} {victim.Surname} ({victim.Class}) takes {specVal[0] * innerVal[0]} damage! {victim.CurHP} HP left!");
            }
        }

        public static void FogTrig(string triggerType, Char attacker, Char victim, float[] specVal, ref float[] innerVal)
        {
            if (triggerType == "HitBySpell")
            {
                if (innerVal[0] > 0)
                {
                    Random rnd = new Random();
                    if (rnd.Next(0, 100) < innerVal[1])
                    {
                        Console.WriteLine($"{attacker.Name} {attacker.Surname} ({attacker.Class}) tries to attack!");
                        throw new ProtectException($"Miss! {victim.Name} {victim.Surname} ({victim.Class}) hides in the smoke screen and takes no damage!");
                    }
                }
            }

            if ((triggerType == "TurnEnd") && (specVal[0] == 1))
            {
                innerVal[0]--;
            }
        }

        public static void FireTrig(string triggerType, Char attacker, Char victim, float[] specVal, ref float[] innerVal)
        {
            if ((triggerType == "TurnEnd") && (specVal[0] == 1) && (innerVal[3] > 0))
            {
                Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is on fire!");
                victim.TakeDamage(attacker, innerVal[1]);
                innerVal[3]--;
            }
        }

        public static List<Spell> RetPalSpells()
        {
            List<Spell> palSpells = new List<Spell>();
            Spell palBaseAttack = new Spell(1);
            palBaseAttack.IsRanged = false;
            palBaseAttack.Lvl = 1;
            palBaseAttack.Name = "Shield Bash";
            palBaseAttack.Castt = BaseAttackFunc;
            palBaseAttack.Triggerr = TrigEmpty;
            palBaseAttack.SpecVal[0] = 10;
            palSpells.Add(palBaseAttack);
            Spell palHammerStrike = new Spell(2);
            palHammerStrike.IsRanged = false;
            palHammerStrike.Lvl = 1;
            palHammerStrike.Name = "Hammer Strike";
            palHammerStrike.Castt = HammerStrikeFunc;
            palHammerStrike.Triggerr = TrigEmpty;
            palHammerStrike.SpecVal[0] = 10;
            palHammerStrike.SpecVal[1] = 1;
            palSpells.Add(palHammerStrike);
            Spell palDef = new Spell(1);
            palDef.IsRanged = false;
            palDef.Lvl = 1;
            palDef.Name = "Shield";
            palDef.Castt = CastEmpty;
            palDef.Triggerr = PalBlockTrig;
            palDef.SpecVal[0] = (float)0.75;
            palSpells.Add(palDef);
            Spell palHeal = new Spell(1);
            palHeal.IsRanged = false;
            palHeal.Lvl = 1;
            palHeal.Name = "Faith in the Light";
            palHeal.Castt = HealFunc;
            palHeal.Triggerr = TrigEmpty;
            palHeal.SpecVal[0] = 12;
            palSpells.Add(palHeal);
            return palSpells;
        }

        public static List<Spell> RetNinjaSpells()
        {
            List<Spell> ninjSpells = new List<Spell>();
            Spell ninjaBaseAttack = new Spell(1);
            ninjaBaseAttack.IsRanged = false;
            ninjaBaseAttack.Lvl = 1;
            ninjaBaseAttack.Name = "Katana Slash";
            ninjaBaseAttack.Castt = BaseAttackFunc;
            ninjaBaseAttack.Triggerr = TrigEmpty;
            ninjaBaseAttack.SpecVal[0] = 17;
            ninjSpells.Add(ninjaBaseAttack);
            Spell ninjaShurikens = new Spell(2);
            ninjaShurikens.IsRanged = true;
            ninjaShurikens.Lvl = 1;
            ninjaShurikens.Name = "Shurikens Throw";
            ninjaShurikens.Castt = ShurikensFunc;
            ninjaShurikens.Triggerr = TrigEmpty;
            ninjaShurikens.SpecVal[0] = 7;
            ninjaShurikens.SpecVal[1] = 3;
            ninjSpells.Add(ninjaShurikens);
            Spell ninjaFog = new Spell(3);
            ninjaFog.IsRanged = false;
            ninjaFog.Lvl = 1;
            ninjaFog.Name = "Smoke Screen";
            ninjaFog.Castt = FogFunc;
            ninjaFog.Triggerr = FogTrig;
            ninjaFog.SpecVal[0] = 0;
            ninjaFog.SpecVal[1] = 26;
            ninjaFog.SpecVal[2] = 3;
            ninjSpells.Add(ninjaFog);
            Spell ninjaPierce = new Spell(1);
            ninjaPierce.IsRanged = false;
            ninjaPierce.Lvl = 1;
            ninjaPierce.Name = "Piercing Slash";
            ninjaPierce.Castt = PierceFunc;
            ninjaPierce.Triggerr = TrigEmpty;
            ninjaPierce.SpecVal[0] = 19;
            ninjSpells.Add(ninjaPierce);
            return ninjSpells;
        }

        public static List<Spell> RetMageSpells()
        {
            List<Spell> magSpells = new List<Spell>();
            Spell mageBaseAttack = new Spell(1);
            mageBaseAttack.IsRanged = false;
            mageBaseAttack.Lvl = 1;
            mageBaseAttack.Name = "Staff Strike";
            mageBaseAttack.Castt = BaseAttackFunc;
            mageBaseAttack.Triggerr = TrigEmpty;
            mageBaseAttack.SpecVal[0] = 5;
            magSpells.Add(mageBaseAttack);
            Spell mageFireball = new Spell(4);
            mageFireball.IsRanged = true;
            mageFireball.Lvl = 1;
            mageFireball.Name = "Fireball Toss";
            mageFireball.Castt = FireballFunc;
            mageFireball.Triggerr = FireTrig;
            mageFireball.SpecVal[0] = 15;
            mageFireball.SpecVal[1] = 5;
            mageFireball.SpecVal[2] = 3;
            mageFireball.SpecVal[3] = 0;
            magSpells.Add(mageFireball);
            return magSpells;
        }
    }
}
