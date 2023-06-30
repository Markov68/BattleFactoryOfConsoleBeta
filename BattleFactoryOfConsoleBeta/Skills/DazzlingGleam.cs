using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class DazzlingGlam:Skill
    {
        public DazzlingGlam() : base("マジカルシャイン", Type.Types.Fairy, Kind.cattack, 80, 10, 100,0,false) 
        {
        }
    }
}
