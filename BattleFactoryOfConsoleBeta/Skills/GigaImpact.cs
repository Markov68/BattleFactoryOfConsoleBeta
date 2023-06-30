using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class GigaImpact:Skill
    {
        public GigaImpact() : base("ギガインパクト", Type.Types.Nomal, Kind.attack, 150, 5, 90,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                pokemon.Recoil = true;
            }
        }


    }
}
