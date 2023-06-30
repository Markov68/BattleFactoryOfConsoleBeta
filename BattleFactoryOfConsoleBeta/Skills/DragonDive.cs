using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class DragonDive:Skill
    {
        public DragonDive() : base("ドラゴンダイブ", Type.Types.Dragon, Kind.attack, 100, 10, 75,0,true) 
        {

        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Random r = new Random();
                if ((r.Next(1, 101) <= 20) && (target.Abilities.Name != "せいしんりょく"))
                {
                    target.Flinch = true;
                }
            }
        }


    }
}
