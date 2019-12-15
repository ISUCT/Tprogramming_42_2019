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
                        if (rnd.Next(0, 100) > 65)
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
                        float[] f = new float[1] { 0 };
                        item.Trigger("TurnEnd", a, b, f);
                    }

                    foreach (Spell item in b.PasSpells)
                    {
                        float[] f = new float[1] { 1 };
                        item.Trigger("TurnEnd", b, a, f);
                    }
                }
                else
                {
                    if (b.StunTimer == 0)
                    {
                        if (rnd.Next(0, 100) > 65)
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
                        float[] f = new float[1] { 0 };
                        item.Trigger("TurnEnd", b, a, f);
                    }

                    foreach (Spell item in a.PasSpells)
                    {
                        float[] f = new float[1] { 1 };
                        item.Trigger("TurnEnd", a, b, f);
                    }
                }

                turn++;
            }

            if (a.CurHP > 0)
            {
                Console.WriteLine($"{a.Name} {a.Surname} ({a.Class}) wins!");
                a.Heal(a.MaxHP);
                foreach (Spell item in a.PasSpells)
                {
                    item.Trigger("EndBattle", a, b, null);
                }

                return 1;
            }
            else
            {
                Console.WriteLine($"{b.Name} {b.Surname} ({b.Class}) wins!");
                b.Heal(b.MaxHP);
                return 0;
            }
        }

        public static Char Tournament(List<Char> charss)
        {
            List<Char> chars = charss;
            while (chars.Count > 1)
            {
                int i = 0;
                while (i < chars.Count)
                {
                    Console.WriteLine($"Let the battle between {chars[i].Name} {chars[i].Surname} ({chars[i].Class}) and {chars[i + 1].Name} {chars[i + 1].Surname} ({chars[i + 1].Class}) begin!");
                    int r = Battle(chars[i], chars[i + 1]);
                    chars.RemoveAt(r + i);
                    i++;
                }
            }

            return chars[0];
        }

        public static void Main()
        {
            palaSpells = RetPalSpells();
            ninjaSpells = RetNinjaSpells();
            mageSpells = RetMageSpells();

            // palSpells.Add(palBaseAttack);
            Console.WriteLine("Welcome to the Battle for Glory Arena. Press any key to start");
            /*Console.ReadKey();
            Console.WriteLine("Choose your class, type 'Paladin', 'Ninja' or 'Mage' here: ");
            string playerClass = Console.ReadLine();
            while ((playerClass != "Paladin") && (playerClass != "Ninja") && (playerClass != "Mage"))
            {
                Console.WriteLine("Error recognizing class, try to write again or copy and paste class name here: ");
                playerClass = Console.ReadLine();
            }*/

            Char player = new Char();
            player.Class = "Paladin";
            player.CurHP = 60;
            player.MaxHP = 60;
            player.ActSpells.Add(palaSpells[0]);
            player.ActSpells.Add(palaSpells[1]);
            player.PasSpells.Add(palaSpells[2]);
            player.ActSpells.Add(palaSpells[3]);
            player.Name = "Arthas";
            player.Surname = "Menethil";
            Char player2 = new Char();
            player2.Class = "Paladin";
            player2.CurHP = 60;
            player2.MaxHP = 60;
            player2.ActSpells.Add(palaSpells[0]);
            player2.ActSpells.Add(palaSpells[1]);
            player2.PasSpells.Add(palaSpells[2]);
            player2.ActSpells.Add(palaSpells[3]);
            player2.Name = "Bolvar";
            player2.Surname = "Fordragon";
            Char vict = new Char();
            vict.Class = "Mage";
            vict.ActSpells.Add(mageSpells[0]);
            vict.ActSpells.Add(mageSpells[1]);
            vict.PasSpells.Add(mageSpells[1]);
            vict.ActSpells.Add(mageSpells[2]);
            vict.ActSpells.Add(mageSpells[3]);
            vict.PasSpells.Add(mageSpells[3]);
            vict.Name = "Jaina";
            vict.Surname = "Proudmoore";
            vict.CurHP = 45;
            vict.MaxHP = 45;
            Char vict2 = new Char();
            vict2.Class = "Ninja";
            vict2.ActSpells.Add(ninjaSpells[0]);
            vict2.ActSpells.Add(ninjaSpells[1]);
            vict2.PasSpells.Add(ninjaSpells[2]);
            vict2.ActSpells.Add(ninjaSpells[2]);
            vict2.ActSpells.Add(ninjaSpells[3]);
            vict2.Name = "Mikey";
            vict2.Surname = "Splinterson";
            vict2.CurHP = 55;
            vict2.MaxHP = 55;

            // player.HitBySpell(vict, vict.ActSpells[3]);

            // Battle(player, vict);
            /*Console.WriteLine($"Victim has {vict.CurHP} HP");
            vict.HitBySpell(player, player.Spells[0]);
            Console.WriteLine($"And now he has {vict.CurHP} HP");*/
            List<Char> chars = new List<Char>();
            chars.Add(player);
            chars.Add(vict);
            chars.Add(player2);
            chars.Add(vict2);
            Char winner = Tournament(chars);
            Console.WriteLine($"{winner.Name} {winner.Surname} ({winner.Class}) won the tournament!");
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

        public static void IceBlastFunc(Char caster, Char victim, ref float[] specVal)
        {
            Console.WriteLine($"{victim.Name} {victim.Surname} ({victim.Class}) is frozen for {(int)specVal[1]} turn(s)!");
            victim.TakeDamage(caster, specVal[0]);
            victim.StunTimer += (int)specVal[1];
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

        public static void MagicShieldFunc(Char caster, Char victim, ref float[] specVal)
        {
            specVal[1] = specVal[0];
            Console.WriteLine($"{caster.Name} {caster.Surname} ({caster.Class}) is protected from any attacks for {specVal[0]} enemy turns!");
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

        public static void FireTrig(string triggerType, Char attacker, Char victim, float[] specVal, ref float[] innerVal)
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

        public static void MageShieldTrig(string triggerType, Char attacker, Char victim, float[] specVal, ref float[] innerVal)
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
            ninjaBaseAttack.SpecVal[0] = 20;
            ninjSpells.Add(ninjaBaseAttack);
            Spell ninjaShurikens = new Spell(2);
            ninjaShurikens.IsRanged = true;
            ninjaShurikens.Lvl = 1;
            ninjaShurikens.Name = "Shurikens Throw";
            ninjaShurikens.Castt = ShurikensFunc;
            ninjaShurikens.Triggerr = TrigEmpty;
            ninjaShurikens.SpecVal[0] = 10;
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
            ninjaPierce.SpecVal[0] = 25;
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
            mageFireball.SpecVal[0] = 30;
            mageFireball.SpecVal[1] = 10;
            mageFireball.SpecVal[2] = 3;
            mageFireball.SpecVal[3] = 0;
            magSpells.Add(mageFireball);
            Spell mageIceBlast = new Spell(2);
            mageIceBlast.IsRanged = true;
            mageIceBlast.Lvl = 1;
            mageIceBlast.Name = "Ice Blast";
            mageIceBlast.Castt = IceBlastFunc;
            mageIceBlast.Triggerr = TrigEmpty;
            mageIceBlast.SpecVal[0] = 20;
            mageIceBlast.SpecVal[1] = 2;
            magSpells.Add(mageIceBlast);
            Spell mageShield = new Spell(2);
            mageShield.IsRanged = false;
            mageShield.Lvl = 1;
            mageShield.Name = "Magic Shield";
            mageShield.Castt = MagicShieldFunc;
            mageShield.Triggerr = MageShieldTrig;
            mageShield.SpecVal[0] = 2;
            mageShield.SpecVal[1] = 0;
            magSpells.Add(mageShield);
            return magSpells;
        }
    }
}
