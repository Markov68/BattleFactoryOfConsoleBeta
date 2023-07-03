using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class PowerGem:Skill
    {
        public PowerGem() : base("パワージェム", Type.Types.Rock, Kind.cattack, 80, 20, 1000,0,false) 
        {
        }


    }
}
