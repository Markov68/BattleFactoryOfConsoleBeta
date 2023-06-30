using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Hydropump : Skill
    {
        public Hydropump() :base("ハイドロポンプ", Type.Types.Water, Kind.cattack, 110, 5, 80,0,false) { }

    }
}
