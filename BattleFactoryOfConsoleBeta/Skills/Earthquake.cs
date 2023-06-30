using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Earthquake: Skill
    {
        public Earthquake() : base("じしん", Type.Types.Grand, Kind.attack, 100, 10, 100,0,false) 
        {
        }


    }
}
