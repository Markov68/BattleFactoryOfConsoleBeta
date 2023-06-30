using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class AuraSphere : Skill
    {
        public AuraSphere() : base("はどうだん", Type.Types.Fight, Kind.cattack, 80, 20, 1000, 0, false)
        {
        }

    }
}
