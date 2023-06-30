using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class PlayRough:Skill
    {
        public PlayRough() : base("じゃれつく", Type.Types.Fairy, Kind.attack, 90, 10, 90,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            target.Arank -= 1;
            check.CheckRankState(target);
            if (target.Abilities.Name == "クリアボディ")
            {
                Console.WriteLine("クリアボディのこうかでのうりょくがさがらない!");
            }
            else
            {
                Console.WriteLine($"{target.Name}のこうげきがさがった!");
            }

        }
    }
}
