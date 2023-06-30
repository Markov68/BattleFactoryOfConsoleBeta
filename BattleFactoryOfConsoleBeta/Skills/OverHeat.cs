using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class OverHeat:Skill
    {
        public OverHeat() :base("オーバーヒート", Type.Types.Fire, Kind.cattack, 130, 5, 90, 0, false) { }

        public override void AfterDamageEffect(Pokemon pokemon,Pokemon target,double damage) 
        {
            Check check = new Check();
            if(pokemon.Crank == -6) 
            {
                Console.WriteLine($"{pokemon.Name}のとくこうはもうさがらない!");
            }
            else if (pokemon.Crank == -5) 
            {
                Console.WriteLine($"{pokemon.Name}のとくこうがさがった!");
                pokemon.Crank -= 1;
                check.CheckRankState(pokemon);
            }
            else 
            {
                Console.WriteLine($"{pokemon.Name}のとくこうががくっとさがった!");
                pokemon.Crank -= 2;
                check.CheckRankState(pokemon);
            }
        }
    }
}
