using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Waterfall : Skill
    {
        public Waterfall() : base("たきのぼり", Type.Types.Water, Kind.attack, 80, 15, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Random r = new Random();
            if ((r.Next(1, 101) <= 20) && (target.Abilities.Name != "せいしんりょく"))
            {
                target.Flinch = true;
            }

        }
    }
}
