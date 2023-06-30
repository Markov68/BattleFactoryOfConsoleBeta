using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class IronHead:Skill
    {
        public IronHead() : base("アイアンヘッド", Type.Types.Metal, Kind.attack, 80, 15, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Random r = new Random();
            if((r.Next(1,101) <= 30) && (target.Abilities.Name != "せいしんりょく"))
            {
                target.Flinch = true;
            }


        }
    }
}
