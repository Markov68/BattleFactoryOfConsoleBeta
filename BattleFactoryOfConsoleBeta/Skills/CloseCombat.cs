using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace BattleOfConsole.Skills
{
    internal class CloseCombat:Skill
    {
        public CloseCombat() :base("インファイト", Type.Types.Fight, Kind.attack, 120, 5, 100, 0, true) { }

        public override void AfterDamageEffect(Pokemon pokemon,Pokemon target,double damage) 
        {
            Check check = new Check();
            if (pokemon.Brank == -6) 
            {
                Console.WriteLine($"{pokemon.Name}のぼうぎょはもうさがらない!");
            }
            else 
            {
                Console.WriteLine($"{pokemon.Name}のぼうぎょががさがった!");
                pokemon.Brank -= 1;
                check.CheckRankState(pokemon);
            }
            if (pokemon.Drank == -6)
            {
                Console.WriteLine($"{pokemon.Name}のとくぼうはもうさがらない!");
            }
            else
            {
                Console.WriteLine($"{pokemon.Name}のとくぼうがさがった!");
                pokemon.Drank -= 1;
                check.CheckRankState(pokemon);
            }
        }
    }
}
