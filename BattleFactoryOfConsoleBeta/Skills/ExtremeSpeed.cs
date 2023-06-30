using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class ExtremeSpeed:Skill
    {
        public ExtremeSpeed() : base("しんそく", Type.Types.Nomal, Kind.attack, 80, 5, 100, 2, true)
        {
        }
    }
}
