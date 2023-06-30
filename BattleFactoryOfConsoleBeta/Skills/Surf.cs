using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Surf: Skill
    {
        public Surf() : base("なみのり", Type.Types.Water, Kind.cattack, 90, 15, 100, 0, false)
        {
        }

    }
}
