using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Uturn:Skill
    {
        public Uturn() : base("とんぼがえり", Type.Types.Bug, Kind.attack, 70, 20, 1000,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            base.AfterDamageEffect(pokemon, target, damage);
            {
                Battle battle = new Battle();
                if (pokemon == BattleField.OppPokemon)
                {
                    battle.OppPokeTrade(pokemon,target,Field.CurrentField,Weather.CurrentWeather);
                }
                else
                {
                    battle.PokeTrade(pokemon,target,Mine.MyTeam,Field.CurrentField,Weather.CurrentWeather);
                }
            }
        }


    }
}
