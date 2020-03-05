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
            baseAttack.IsPassive = false;
            baseAttack.IsRanged = false;
            baseAttack.Lvl = 1;
            baseAttack.Name = "Shield Bash";
            palSpells.Add(baseAttack);
            HammerStrike hammer = new HammerStrike();
            hammer.IsPassive = false;
            hammer.IsRanged = false;
            hammer.Lvl = 1;
            hammer.Name = "Hammer Strike";
            hammer.StunDuration = 1;
            palSpells.Add(hammer);
            PalBlockSpell palDef = new PalBlockSpell();
            palDef.IsPassive = true;
            palDef.Lvl = 1;
            palDef.Name = "Shield";
            palDef.DamageBlockPercent = (float)75;
            palSpells.Add(palDef);
            PalHeal palHeal = new PalHeal();
            palHeal.IsRanged = false;
            palHeal.Lvl = 1;
            palHeal.Name = "Faith in the Light";
            palHeal.HP = 12;
            palHeal.IsPassive = false;
            palSpells.Add(palHeal);
            PunishLight punishLight = new PunishLight();
            punishLight.IsPassive = false;
            punishLight.IsRanged = false;
            punishLight.Lvl = 1;
            punishLight.Damage = 30;
            punishLight.Name = "Punishing Light";
            palSpells.Add(punishLight);
            return palSpells;
        }

        public static List<ISpell> RetNinjaSpells()
        {
            List<ISpell> ninjSpells = new List<ISpell>();
            BaseAttack baseAttack = new BaseAttack();
            baseAttack.IsPassive = false;
            baseAttack.IsRanged = false;
            baseAttack.Lvl = 1;
            baseAttack.Name = "Katana Slash";
            ninjSpells.Add(baseAttack);
            NinjaShurikens ninjaShurikens = new NinjaShurikens();
            ninjaShurikens.IsRanged = true;
            ninjaShurikens.IsPassive = false;
            ninjaShurikens.Lvl = 1;
            ninjaShurikens.Name = "Shurikens Throw";
            ninjaShurikens.Damage = 10;
            ninjaShurikens.Count = 3;
            ninjSpells.Add(ninjaShurikens);
            NinjaFog ninjaFog = new NinjaFog();
            ninjaFog.IsRanged = false;
            ninjaFog.IsPassive = false;
            ninjaFog.Lvl = 1;
            ninjaFog.Name = "Smoke Screen";
            ninjaFog.DodgeChance = 26;
            ninjaFog.Duration = 3;
            ninjSpells.Add(ninjaFog);
            NinjaPierce ninjaPierce = new NinjaPierce();
            ninjaPierce.IsRanged = false;
            ninjaPierce.IsPassive = false;
            ninjaPierce.Lvl = 1;
            ninjaPierce.Name = "Piercing Slash";
            ninjaPierce.Damage = 5;
            ninjSpells.Add(ninjaPierce);
            return ninjSpells;
        }

        public static List<ISpell> RetMageSpells()
        {
            List<ISpell> magSpells = new List<ISpell>();
            BaseAttack mageBaseAttack = new BaseAttack();
            mageBaseAttack.IsPassive = false;
            mageBaseAttack.IsRanged = false;
            mageBaseAttack.Lvl = 1;
            mageBaseAttack.Name = "Staff Strike";
            magSpells.Add(mageBaseAttack);
            MageFireball mageFireball = new MageFireball();
            mageFireball.IsPassive = false;
            mageFireball.IsRanged = true;
            mageFireball.Lvl = 1;
            mageFireball.Name = "Fireball Toss";
            mageFireball.Damage = 30;
            mageFireball.TickDamage = 10;
            mageFireball.TickDuration = 3;
            magSpells.Add(mageFireball);
            MageIceBlast mageIceBlast = new MageIceBlast();
            mageIceBlast.IsRanged = true;
            mageIceBlast.IsPassive = false;
            mageIceBlast.Lvl = 1;
            mageIceBlast.Name = "Ice Blast";
            mageIceBlast.DamageReducted = 7;
            mageIceBlast.StunDuration = 2;
            magSpells.Add(mageIceBlast);
            MageShield mageShield = new MageShield();
            mageShield.IsRanged = false;
            mageShield.IsPassive = false;
            mageShield.Lvl = 1;
            mageShield.Name = "Magic Shield";
            mageShield.Duration = 2;
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

        public static List<Character> RetFighters(int count)
        {
            List<Character> fighters = new List<Character>();
            for (int i = 0; i < count; i++)
            {
                Character a = new Character();
                Random rnd = new Random();
                int clas = rnd.Next(1, 4);
                switch (clas)
                {
                    case 1:
                        a = ReturnRandomCharacter();
                        break;
                    case 2:
                        a = ReturnRandomCharacter("Ninja", 5, 15, 15, 25, 1, 5);
                        break;
                    case 3:
                        a = ReturnRandomCharacter("Mage", 5, 15, 1, 5, 20, 30);
                        break;
                }

                fighters.Add(a);
            }

            return fighters;
        }

        public static Character ReturnRandomCharacter(string className = "Paladin", int minStrength = 15, int maxStrength = 25, int minAgility = 5, int maxAgility = 15, int minIntelligence = 1, int maxIntelligence = 5)
        {
            Character a = new Character();
            a.Class = className;
            Random rnd = new Random();
            if (className == "Paladin")
            {
                List<ISpell> list = RetPalSpells();
                a.GainSpell(list[0]);
                for (int i = 0; i < 3; i++)
                {
                    int tempInt = rnd.Next(1, list.Count);
                    a.GainSpell(list[tempInt]);
                    list.RemoveAt(tempInt);
                }
            }
            else
            {
                if (className == "Ninja")
                {
                    List<ISpell> list = RetNinjaSpells();
                    a.GainSpell(list[0]);
                    for (int i = 0; i < 3; i++)
                    {
                        int tempInt = rnd.Next(1, list.Count);
                        a.GainSpell(list[tempInt]);
                        list.RemoveAt(tempInt);
                    }
                }
                else
                {
                    if (className == "Mage")
                    {
                        List<ISpell> list = RetMageSpells();
                        a.GainSpell(list[0]);
                        for (int i = 0; i < 3; i++)
                        {
                            int tempInt = rnd.Next(1, list.Count);
                            a.GainSpell(list[tempInt]);
                            list.RemoveAt(tempInt);
                        }
                    }
                    else
                    {
                        throw new Exception("Class not found");
                    }
                }
            }

            a.Strength = rnd.Next(minStrength, maxStrength + 1);
            a.Agility = rnd.Next(minAgility, maxAgility + 1);
            a.Intelligence = rnd.Next(minIntelligence, maxIntelligence + 1);
            a.Name = RetNames()[rnd.Next(0, RetNames().Count)];
            a.Surname = RetSurnames()[rnd.Next(0, RetSurnames().Count)];
            a.MaxHP = a.Strength * 10;
            a.CurHP = a.MaxHP;
            return a;
        }
    }
}
