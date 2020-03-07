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
            baseAttack.Lvl = 1;
            baseAttack.Name = "Shield Bash";
            palSpells.Add(baseAttack);
            HammerStrike hammer = new HammerStrike();
            hammer.Lvl = 1;
            hammer.StunDuration = 1;
            palSpells.Add(hammer);
            PalBlockSpell palDef = new PalBlockSpell();
            palDef.Lvl = 1;
            palDef.DamageBlockPercent = (float)75;
            palSpells.Add(palDef);
            PalHeal palHeal = new PalHeal();
            palHeal.Lvl = 1;
            palHeal.HP = 12;
            palSpells.Add(palHeal);
            PunishLight punishLight = new PunishLight();
            punishLight.Lvl = 1;
            punishLight.Damage = 30;
            palSpells.Add(punishLight);
            return palSpells;
        }

        public static List<ISpell> RetNinjaSpells()
        {
            List<ISpell> ninjSpells = new List<ISpell>();
            BaseAttack baseAttack = new BaseAttack();
            baseAttack.Lvl = 1;
            baseAttack.Name = "Katana Slash";
            ninjSpells.Add(baseAttack);
            NinjaShurikens ninjaShurikens = new NinjaShurikens();
            ninjaShurikens.Lvl = 1;
            ninjaShurikens.Damage = 10;
            ninjaShurikens.Count = 3;
            ninjSpells.Add(ninjaShurikens);
            NinjaFog ninjaFog = new NinjaFog();
            ninjaFog.Lvl = 1;
            ninjaFog.DodgeChance = 26;
            ninjaFog.Duration = 3;
            ninjSpells.Add(ninjaFog);
            NinjaPierce ninjaPierce = new NinjaPierce();
            ninjaPierce.Lvl = 1;
            ninjaPierce.Damage = 5;
            ninjSpells.Add(ninjaPierce);
            NinjaBleed ninjaBleed = new NinjaBleed();
            ninjaBleed.Lvl = 1;
            ninjaBleed.DamagePercent = (float)0.05;
            ninjaBleed.TurnsLeft = 2;
            ninjSpells.Add(ninjaBleed);
            return ninjSpells;
        }

        public static List<ISpell> RetMageSpells()
        {
            List<ISpell> magSpells = new List<ISpell>();
            BaseAttack mageBaseAttack = new BaseAttack();
            mageBaseAttack.Lvl = 1;
            mageBaseAttack.Name = "Staff Strike";
            magSpells.Add(mageBaseAttack);
            MageFireball mageFireball = new MageFireball();
            mageFireball.Lvl = 1;
            mageFireball.Damage = 30;
            mageFireball.TickDamage = 10;
            mageFireball.TickDuration = 3;
            magSpells.Add(mageFireball);
            MageIceBlast mageIceBlast = new MageIceBlast();
            mageIceBlast.Lvl = 1;
            mageIceBlast.DamageReducted = 7;
            mageIceBlast.StunDuration = 2;
            magSpells.Add(mageIceBlast);
            MageShield mageShield = new MageShield();
            mageShield.Lvl = 1;
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
                        a = ReturnRandomCharacter(new CharGenConfig());
                        break;
                    case 2:
                        a = ReturnRandomCharacter(new CharGenConfig() { MinStrength = 5, MaxStrength = 15, MinAgility = 15, MaxAgility = 25, MinIntelligence = 1, MaxIntelligence = 5 }, "Ninja");
                        break;
                    case 3:
                        a = ReturnRandomCharacter(new CharGenConfig() { MinStrength = 5, MaxStrength = 15, MinAgility = 1, MaxAgility = 5, MinIntelligence = 20, MaxIntelligence = 30 },  "Mage");
                        break;
                }

                fighters.Add(a);
            }

            return fighters;
        }

        public static Character ReturnRandomCharacter(CharGenConfig conf, string className = "Paladin")
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

            a.Strength = rnd.Next(conf.MinStrength, conf.MaxStrength + 1);
            a.Agility = rnd.Next(conf.MinAgility, conf.MaxAgility + 1);
            a.Intelligence = rnd.Next(conf.MinIntelligence, conf.MaxIntelligence + 1);
            a.Name = RetNames()[rnd.Next(0, RetNames().Count)];
            a.Surname = RetSurnames()[rnd.Next(0, RetSurnames().Count)];
            a.MaxHP = a.Strength * 10;
            a.CurHP = a.MaxHP;
            return a;
        }
    }
}
