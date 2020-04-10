using System;
using System.Collections.Generic;

namespace RpgAutoBattler
{
    public enum CharacterClass
    {
        Paladin,
        Ninja,
        Mage
    }

    public static class ReturnFuncs
    {
        public static List<ISpell> RetPalSpells()
        {
            List<ISpell> palSpells = new List<ISpell>();
            BaseAttack baseAttack = new BaseAttack
            {
                Lvl = 1,
                Name = "Shield Bash"
            };
            palSpells.Add(baseAttack);
            HammerStrike hammer = new HammerStrike
            {
                Lvl = 1,
                StunDuration = 1
            };
            palSpells.Add(hammer);
            PalBlockSpell palDef = new PalBlockSpell
            {
                Lvl = 1,
                DamageBlockPercent = (float)85
            };
            palSpells.Add(palDef);
            PalHeal palHeal = new PalHeal
            {
                Lvl = 1,
                HP = 10
            };
            palSpells.Add(palHeal);
            PunishLight punishLight = new PunishLight
            {
                Lvl = 1,
                Damage = 17
            };
            palSpells.Add(punishLight);
            return palSpells;
        }

        public static List<ISpell> RetNinjaSpells()
        {
            List<ISpell> ninjSpells = new List<ISpell>();
            BaseAttack baseAttack = new BaseAttack
            {
                Lvl = 1,
                Name = "Katana Slash"
            };
            ninjSpells.Add(baseAttack);
            NinjaShurikens ninjaShurikens = new NinjaShurikens
            {
                Lvl = 1,
                Damage = 12,
                Count = 3
            };
            ninjSpells.Add(ninjaShurikens);
            NinjaFog ninjaFog = new NinjaFog
            {
                Lvl = 1,
                DodgeChance = 45,
                Duration = 3
            };
            ninjSpells.Add(ninjaFog);
            NinjaPierce ninjaPierce = new NinjaPierce
            {
                Lvl = 1,
                Damage = 15
            };
            ninjSpells.Add(ninjaPierce);
            NinjaBleed ninjaBleed = new NinjaBleed
            {
                Lvl = 1,
                DamagePercent = (float)0.1,
                TurnsLeft = 2
            };
            ninjSpells.Add(ninjaBleed);
            return ninjSpells;
        }

        public static List<ISpell> RetMageSpells()
        {
            List<ISpell> magSpells = new List<ISpell>();
            BaseAttack mageBaseAttack = new BaseAttack
            {
                Lvl = 1,
                Name = "Staff Strike"
            };
            magSpells.Add(mageBaseAttack);
            MageFireball mageFireball = new MageFireball
            {
                Lvl = 1,
                Damage = 15,
                TickDamage = 20,
                TickDuration = 3
            };
            magSpells.Add(mageFireball);
            MageIceBlast mageIceBlast = new MageIceBlast
            {
                Lvl = 1,
                DamageReducted = 7,
                StunDuration = 2
            };
            magSpells.Add(mageIceBlast);
            MageShield mageShield = new MageShield
            {
                Lvl = 1,
                Duration = 2
            };
            magSpells.Add(mageShield);
            MageLightning mageLightning = new MageLightning
            {
                Lvl = 1,
                DamageMultiplier = 3
            };
            magSpells.Add(mageLightning);
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
                        a = ReturnRandomCharacter(new CharGenConfig() { MinStrength = 5, MaxStrength = 15, MinAgility = 15, MaxAgility = 25, MinIntelligence = 1, MaxIntelligence = 5 }, CharacterClass.Ninja);
                        break;
                    case 3:
                        a = ReturnRandomCharacter(new CharGenConfig() { MinStrength = 5, MaxStrength = 15, MinAgility = 1, MaxAgility = 5, MinIntelligence = 20, MaxIntelligence = 30 },  CharacterClass.Mage);
                        break;
                }

                fighters.Add(a);
            }

            return fighters;
        }

        public static Character ReturnRandomCharacter(CharGenConfig conf, CharacterClass className = CharacterClass.Paladin)
        {
            Character a = new Character();
            Random rnd = new Random();
            switch (className)
            {
                case CharacterClass.Paladin:
                    a = CharacterFactory.CreatePaladin();
                    break;
                case CharacterClass.Ninja:
                    a = CharacterFactory.CreateNinja();
                    break;
                case CharacterClass.Mage:
                    a = CharacterFactory.CreateMage();
                    break;
            }

            a.Strength = rnd.Next(conf.MinStrength, conf.MaxStrength + 1);
            a.Agility = rnd.Next(conf.MinAgility, conf.MaxAgility + 1);
            a.Intelligence = rnd.Next(conf.MinIntelligence, conf.MaxIntelligence + 1);
            a.MaxHP = a.Strength * 10;
            a.CurHP = a.MaxHP;
            return a;
        }
    }
}
