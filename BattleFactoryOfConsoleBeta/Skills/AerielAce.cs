using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class AerielAce:Skill
    {
        public AerielAce() : base("つばめがえし", Type.Types.Fly, Kind.attack, 60, 20, 1000,0,true) 
        {
        }


    }
}
