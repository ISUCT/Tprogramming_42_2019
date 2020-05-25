using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public static class ReturnFuncs
    {
        public static List<ISpell> GetHunterSpells()
        {
            BaseAttack baseAttack = new BaseAttack { Name = "hand gun shot" };

            Bandage bandage = new Bandage { Name = "Bandages" };

            BullsEye bullsEye = new BullsEye { Name = "BullsEye" };

            DaggerThrow daggerThrow = new DaggerThrow { Name = "Dagger throw" };
            List<ISpell> spells = new List<ISpell>() { baseAttack, bandage, bullsEye, daggerThrow };
            return spells;
        }

        public static List<ISpell> GetTitanSpells()
        {
            BaseAttack baseAttack = new BaseAttack { Name = "Rifle shot" };

            FirstAidKit firstAidKit = new FirstAidKit { Name = "first aid kit" };

            FistPunch fistPunch = new FistPunch { Name = "Fist punch" };

            GrenadeThrow grenadeThrow = new GrenadeThrow { Name = "Grenade throw" };

            List<ISpell> spells = new List<ISpell>() { baseAttack, firstAidKit, fistPunch, grenadeThrow };
            return spells;
        }

        public static List<ISpell> GetWarlockSpells()
        {
            BaseAttack baseAttack = new BaseAttack { Name = "hand gun shot" };

            HealingRift healingRift = new HealingRift { Name = "Healing rift" };

            VoidBlast voidBlast = new VoidBlast { Name = "Void blast" };

            VoidSlash voidSlash = new VoidSlash { Name = "Void slash" };

            List<ISpell> spells = new List<ISpell>() { baseAttack, healingRift, voidBlast, voidSlash };
            return spells;
        }
    }
}
