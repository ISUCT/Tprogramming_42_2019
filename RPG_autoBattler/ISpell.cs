using System;

namespace RPG_autoBattler
{
    public interface ISpell
    {
        string Name { get; set; }

        int Lvl { get; set; }

        bool IsPassive { get; set; }

        bool IsRanged { get; set; }

        void Cast(Char caster, Char victim);

        void Trigger(string triggerType, Char attacker, Char victim, float[] specValue);
    }

    /*public interface IActiveSpell
    {
        bool IsRanged { get; set; }

        void Cast(Char caster, Char victim);
    }*/

    public interface IPassiveSpell
    {
        int TurnsLeft { get; set; }

        void Trigger(string triggerType, Char attacker, Char victim, float[] specValue);
    }
}
