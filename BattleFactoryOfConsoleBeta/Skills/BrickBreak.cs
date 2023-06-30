using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class BrickBreak:Skill
    {
        public BrickBreak() : base("かわらわり", Type.Types.Fight, Kind.attack, 75, 15, 100,0,true) 
        {
        }
    }
}
