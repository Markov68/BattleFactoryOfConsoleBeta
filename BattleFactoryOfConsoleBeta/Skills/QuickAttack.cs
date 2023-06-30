using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;

namespace BattleOfConsole.Skills
{
    internal class QuickAttack : Skill
    {
        public QuickAttack() : base("でんこうせっか", Type.Types.Nomal, Kind.attack, 40, 30, 100,1, true)
        {
        }
    }
}
