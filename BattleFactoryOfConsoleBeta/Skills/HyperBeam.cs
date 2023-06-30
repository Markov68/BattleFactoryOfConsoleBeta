using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class HyperBeam:Skill
    {
        public HyperBeam() : base("はかいこうせん", Type.Types.Nomal, Kind.cattack, 150, 5, 90,0,false) 
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
