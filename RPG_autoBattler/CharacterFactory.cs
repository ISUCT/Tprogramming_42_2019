using System;
using System.Collections.Generic;

namespace RpgAutoBattler
{
    public static class CharacterFactory
    {
        public static Character CreatePaladin()
        {
            Random rnd = new Random();
            Character a = new Character
            {
                Class = CharacterClass.Paladin,
                Name = ReturnFuncs.RetNames()[rnd.Next(0, ReturnFuncs.RetNames().Count)],
                Surname = ReturnFuncs.RetSurnames()[rnd.Next(0, ReturnFuncs.RetSurnames().Count)]
            };
            List<ISpell> list = ReturnFuncs.RetPalSpells();
            a.GainSpell(list[0]);
            for (int i = 0; i < 3; i++)
            {
                int tempInt = rnd.Next(1, list.Count);
                a.GainSpell(list[tempInt]);
                list.RemoveAt(tempInt);
            }

            return a;
        }

        public static Character CreateNinja()
        {
            Random rnd = new Random();
            Character a = new Character
            {
                Class = CharacterClass.Ninja,
                Name = ReturnFuncs.RetNames()[rnd.Next(0, ReturnFuncs.RetNames().Count)],
                Surname = ReturnFuncs.RetSurnames()[rnd.Next(0, ReturnFuncs.RetSurnames().Count)]
            };
            List<ISpell> list = ReturnFuncs.RetNinjaSpells();
            a.GainSpell(list[0]);
            for (int i = 0; i < 3; i++)
            {
                int tempInt = rnd.Next(1, list.Count);
                a.GainSpell(list[tempInt]);
                list.RemoveAt(tempInt);
            }

            return a;
        }

        public static Character CreateMage()
        {
            Random rnd = new Random();
            Character a = new Character
            {
                Class = CharacterClass.Mage,
                Name = ReturnFuncs.RetNames()[rnd.Next(0, ReturnFuncs.RetNames().Count)],
                Surname = ReturnFuncs.RetSurnames()[rnd.Next(0, ReturnFuncs.RetSurnames().Count)]
            };
            List<ISpell> list = ReturnFuncs.RetMageSpells();
            a.GainSpell(list[0]);
            for (int i = 0; i < 3; i++)
            {
                int tempInt = rnd.Next(1, list.Count);
                a.GainSpell(list[tempInt]);
                list.RemoveAt(tempInt);
            }

            return a;
        }
    }
}
