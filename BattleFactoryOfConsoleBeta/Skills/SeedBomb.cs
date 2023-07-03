using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class SeedBomb:Skill
    {
        public SeedBomb() : base("タネばくだん", Type.Types.Leaf, Kind.attack, 80, 15, 100,0,false) 
        {
        }


    }
}
