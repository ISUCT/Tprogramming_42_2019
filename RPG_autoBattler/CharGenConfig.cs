using System;
using System.Collections.Generic;

namespace RpgAutoBattler
{
    public class CharGenConfig
    {
        public int MinStrength { get; set; } = 15;

        public int MaxStrength { get; set; } = 25;

        public int MinAgility { get; set; } = 5;

        public int MaxAgility { get; set; } = 15;

        public int MinIntelligence { get; set; } = 1;

        public int MaxIntelligence { get; set; } = 5;
    }
}
