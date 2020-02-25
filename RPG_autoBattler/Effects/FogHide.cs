using System;

namespace RPG_autoBattler
{
    public class FogHide : IPassiveSpell
    {
        public int TurnsLeft { get; set; }

        public int DodgeChance { get; set; }

        public void Trigger(string triggerType, Char attacker, Char victim, float[] specValue)
        {
            if (triggerType == "HitBySpell")
            {
                if (TurnsLeft > 0)
                {
                    Random rnd = new Random();
                    if (rnd.Next(0, 100) < DodgeChance)
                    {
                        Console.WriteLine($"{attacker.Name} {attacker.Surname} ({attacker.Class}) tries to attack!");
                        throw new ProtectException($"Miss! {victim.Name} {victim.Surname} ({victim.Class}) hides in the smoke screen and takes no damage!");
                    }
                }
            }

            if ((triggerType == "EndTurn") && ((int)specValue[0] == 1))
            {
                TurnsLeft--;
            }

            if (triggerType == "EndBattle")
            {
                TurnsLeft = 0;
            }
        }
    }
}