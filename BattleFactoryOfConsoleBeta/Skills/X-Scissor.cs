using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class XScissor:Skill
    {
        public XScissor() : base("シザークロス", Type.Types.Bug, Kind.attack, 80, 15, 100,0,true) 
        {
        }


    }
}
