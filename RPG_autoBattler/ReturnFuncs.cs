using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public static class ReturnFuncs
    {
        public static List<ISpell> RetPalSpells()
        {
            List<ISpell> palSpells = new List<ISpell>();
            BaseAttack baseAttack = new BaseAttack();
            baseAttack.IsRanged = false;
            baseAttack.Lvl = 1;
            baseAttack.Name = "Shield Bash";
            palSpells.Add(baseAttack);
            HammerStrike hammer = new HammerStrike();
            hammer.IsRanged = false;
            hammer.Lvl = 1;
            hammer.Name = "Hammer Strike";
            hammer.StunDuration = 1;
            palSpells.Add(hammer);
            PalBlockSpell palDef = new PalBlockSpell();
            palDef.Lvl = 1;
            palDef.Name = "Shield";
            palDef.DamageBlockPercent = (float)75;
            palSpells.Add(palDef);
            PalHeal palHeal = new PalHeal();
            palHeal.IsRanged = false;
            palHeal.Lvl = 1;
            palHeal.Name = "Faith in the Light";
            palHeal.HP = 12;
            palSpells.Add(palHeal);
            return palSpells;
        }

        public static List<Spell> RetNinjaSpells()
        {
            List<Spell> ninjSpells = new List<Spell>();
            Spell ninjaBaseAttack = new Spell(1);
            ninjaBaseAttack.IsRanged = false;
            ninjaBaseAttack.Lvl = 1;
            ninjaBaseAttack.IsPassive = 0;
            ninjaBaseAttack.Name = "Katana Slash";
            ninjaBaseAttack.Castt = CastTriggerFuncs.BaseAttackFunc;
            ninjaBaseAttack.Triggerr = CastTriggerFuncs.TrigEmpty;
            ninjaBaseAttack.SpecVal[0] = 20;
            ninjSpells.Add(ninjaBaseAttack);
            Spell ninjaShurikens = new Spell(2);
            ninjaShurikens.IsRanged = true;
            ninjaShurikens.Lvl = 1;
            ninjaShurikens.IsPassive = 0;
            ninjaShurikens.Name = "Shurikens Throw";
            ninjaShurikens.Castt = CastTriggerFuncs.ShurikensFunc;
            ninjaShurikens.Triggerr = CastTriggerFuncs.TrigEmpty;
            ninjaShurikens.SpecVal[0] = 10;
            ninjaShurikens.SpecVal[1] = 3;
            ninjSpells.Add(ninjaShurikens);
            Spell ninjaFog = new Spell(3);
            ninjaFog.IsRanged = false;
            ninjaFog.Lvl = 1;
            ninjaFog.IsPassive = 2;
            ninjaFog.Name = "Smoke Screen";
            ninjaFog.Castt = CastTriggerFuncs.FogFunc;
            ninjaFog.Triggerr = CastTriggerFuncs.FogTrig;
            ninjaFog.SpecVal[0] = 0;
            ninjaFog.SpecVal[1] = 26;
            ninjaFog.SpecVal[2] = 3;
            ninjSpells.Add(ninjaFog);
            Spell ninjaPierce = new Spell(1);
            ninjaPierce.IsRanged = false;
            ninjaPierce.Lvl = 1;
            ninjaPierce.Name = "Piercing Slash";
            ninjaPierce.Castt = CastTriggerFuncs.PierceFunc;
            ninjaPierce.Triggerr = CastTriggerFuncs.TrigEmpty;
            ninjaPierce.SpecVal[0] = 5;
            ninjSpells.Add(ninjaPierce);
            return ninjSpells;
        }

        public static List<Spell> RetMageSpells()
        {
            List<Spell> magSpells = new List<Spell>();
            Spell mageBaseAttack = new Spell(1);
            mageBaseAttack.IsRanged = false;
            mageBaseAttack.Lvl = 1;
            mageBaseAttack.IsPassive = 0;
            mageBaseAttack.Name = "Staff Strike";
            mageBaseAttack.Castt = CastTriggerFuncs.BaseAttackFunc;
            mageBaseAttack.Triggerr = CastTriggerFuncs.TrigEmpty;
            mageBaseAttack.SpecVal[0] = 5;
            magSpells.Add(mageBaseAttack);
            Spell mageFireball = new Spell(4);
            mageFireball.IsRanged = true;
            mageFireball.Lvl = 1;
            mageFireball.IsPassive = 2;
            mageFireball.Name = "Fireball Toss";
            mageFireball.Castt = CastTriggerFuncs.FireballFunc;
            mageFireball.Triggerr = CastTriggerFuncs.FireTrig;
            mageFireball.SpecVal[0] = 30;
            mageFireball.SpecVal[1] = 10;
            mageFireball.SpecVal[2] = 3;
            mageFireball.SpecVal[3] = 0;
            magSpells.Add(mageFireball);
            Spell mageIceBlast = new Spell(2);
            mageIceBlast.IsRanged = true;
            mageIceBlast.Lvl = 1;
            mageIceBlast.IsPassive = 0;
            mageIceBlast.Name = "Ice Blast";
            mageIceBlast.Castt = CastTriggerFuncs.IceBlastFunc;
            mageIceBlast.Triggerr = CastTriggerFuncs.TrigEmpty;
            mageIceBlast.SpecVal[0] = 7;
            mageIceBlast.SpecVal[1] = 2;
            magSpells.Add(mageIceBlast);
            Spell mageShield = new Spell(2);
            mageShield.IsRanged = false;
            mageShield.Lvl = 1;
            mageShield.IsPassive = 3;
            mageShield.Name = "Magic Shield";
            mageShield.Castt = CastTriggerFuncs.MagicShieldFunc;
            mageShield.Triggerr = CastTriggerFuncs.MageShieldTrig;
            mageShield.SpecVal[0] = 2;
            mageShield.SpecVal[1] = 0;
            magSpells.Add(mageShield);
            return magSpells;
        }

        public static List<string> RetNames()
        {
            List<string> s = new List<string>() { "Arthas", "Jaina", "Bolvar", "Mikey", "Perry", "Leonardo", "Donatello", "Raphael", "Sylvanas", "Alleria", "Vlad", "Vitaliy", "Thrall", "Geralt", "Daelin" };
            return s;
        }

        public static List<string> RetSurnames()
        {
            List<string> s = new List<string>() { "Menethil", "Proudmoore", "Fordragon", "Splinterson", "the Platypus", "Windrunner", "Dracula", "Tsal'", "from Rivia", "Gorobets" };
            return s;
        }

        public static List<Char> RetFighters(int count)
        {
            List<Char> fighters = new List<Char>();
            for (int i = 0; i < count; i++)
            {
                Char a = new Char();
                Random rnd = new Random();
                int clas = rnd.Next(1, 3);
                switch (clas)
                {
                    case 1:
                        a.Class = "Paladin";

                        // потом в каждом кейзе создавать нью лист и рандомно из него добавлять спеллы, а добавленные удалять. Так как создаётся новый на основе возвращения функции, то ничего не перезапишется
                        foreach (Spell item in RetPalSpells())
                        {
                            a.GainSpell(item);
                        }

                        a.Strength = rnd.Next(15, 25);
                        a.Agility = rnd.Next(5, 15);
                        a.Intelligence = rnd.Next(1, 5);

                        break;
                    case 2:
                        a.Class = "Ninja";
                        foreach (Spell item in RetNinjaSpells())
                        {
                            a.GainSpell(item);
                        }

                        a.Strength = rnd.Next(5, 15);
                        a.Agility = rnd.Next(15, 25);
                        a.Intelligence = rnd.Next(1, 5);
                        break;
                    case 3:
                        a.Class = "Mage";
                        foreach (Spell item in RetMageSpells())
                        {
                            a.GainSpell(item);
                        }

                        a.Strength = rnd.Next(5, 15);
                        a.Agility = rnd.Next(1, 5);
                        a.Intelligence = rnd.Next(20, 30);
                        break;
                }

                a.Name = RetNames()[rnd.Next(0, RetNames().Count)];
                a.Surname = RetSurnames()[rnd.Next(0, RetSurnames().Count)];
                a.MaxHP = a.Strength * 10;
                a.CurHP = a.MaxHP;
                fighters.Add(a);
            }

            return fighters;
        }
    }
}
