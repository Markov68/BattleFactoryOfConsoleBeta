using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class DragonClaw:Skill
    {
        public DragonClaw() : base("ドラゴンクロー", Type.Types.Dragon, Kind.attack, 80, 15, 100,0,true) 
        {
        }


    }
}
