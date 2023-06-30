using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;

namespace BattleOfConsole.Skills
{
    internal class MachPunch : Skill
    {
        public MachPunch() : base("マッハパンチ", Type.Types.Fight, Kind.attack, 40, 30, 100,1, true)
        {
        }
    }
}
