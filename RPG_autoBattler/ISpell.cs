using System;

namespace RPG_autoBattler
{
    public interface ISpell
    {
        string Name { get; set; }

        int Lvl { get; set; }

        bool IsPassive { get; set; }

        bool IsRanged { get; set; }

        void Cast(Character caster, Character victim);

        void Trigger(string triggerType, Character attacker, Character victim, float[] specValue);
    }

    /*public interface IActiveSpell
    {
        bool IsRanged { get; set; }

        void Cast(Character caster, Character victim);
    }*/

    public interface IPassiveSpell
    {
        int TurnsLeft { get; set; }

        void Trigger(string triggerType, Character attacker, Character victim, float[] specValue);
    }
}
