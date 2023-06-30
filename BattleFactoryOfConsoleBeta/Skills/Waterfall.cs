using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class AirSlash:Skill
    {
        public AirSlash() : base("エアスラッシュ", Type.Types.Fly, Kind.cattack, 75, 15, 95,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Random r = new Random();
            if ((r.Next(1, 101) <= 30) && (target.Abilities.Name != "せいしんりょく"))
            {
                target.Flinch = true;
            }

        }
    }
}
