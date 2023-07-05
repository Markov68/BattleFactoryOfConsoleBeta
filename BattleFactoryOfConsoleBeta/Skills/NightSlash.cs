using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class NightSlash:Skill
    {
        public NightSlash() : base("つじぎり", Type.Types.Dark, Kind.attack, 70, 15, 100,0,true) 
        {
        }

        public override void BeforeAttackEffect(Pokemon pokemon, Pokemon target)
        {
            base.BeforeAttackEffect(pokemon, target);
            {
                pokemon.CriticalHitStage += 1;
            }
        }
    }
}
