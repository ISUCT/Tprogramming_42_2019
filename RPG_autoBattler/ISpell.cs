using System;

namespace RpgAutoBattler
{
    public interface ISpell
    {
        string Name { get; set; }

        int Lvl { get; set; }

        bool IsPassive { get; set; }

        bool IsRanged { get; set; }

        void Cast(Character caster, Character victim);

        void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specValue);
    }

    public interface IPassiveSpell
    {
        int TurnsLeft { get; set; }

        void Trigger(TriggerType triggerType, Character attacker, Character victim, float[] specValue);
    }
}
