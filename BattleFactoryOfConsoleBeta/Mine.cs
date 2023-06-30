using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole
{
    internal class Mine
    {
        public static List<Pokemon> MyTeam = new List<Pokemon>();

        public static bool TradeSkip { get; set; } = false;

        public static bool Flinch { get; set; } = false;
        public static bool Recoil { get; set; } = false;

        public static bool MineStealthRock { get; set; } = false;
    }
}
