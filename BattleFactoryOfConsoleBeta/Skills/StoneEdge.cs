using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BattleOfConsole.Skills
{
    internal class StoneEdge:Skill
    {
        public StoneEdge() : base("ストーンエッジ", Type.Types.Rock, Kind.attack, 100, 5, 80,0,false) 
        {
        }


    }
}
