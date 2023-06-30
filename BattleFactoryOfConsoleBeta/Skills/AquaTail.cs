using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class AquaTail:Skill
    {
        public AquaTail() : base("アクアテール", Type.Types.Water, Kind.attack, 90, 10, 90, 0, true)
        {
        }
    }
}
