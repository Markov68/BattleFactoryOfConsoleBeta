using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class BreakingSwipe:Skill
    {
        public BreakingSwipe() : base("ワイドブレイカー", Type.Types.Dragon, Kind.attack, 60, 15, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            if(target.Abilities.Name == "クリアボディ") 
            {
                Console.WriteLine($"{target.Name}のこうげきはクリアボディでさがらない!");
            }
            else if(target.Arank == -6)
            {
                Console.WriteLine($"{target.Name}のこうげきはもうさがらない!");
            }
            else 
            {
                Console.WriteLine($"{target.Name}のこうげきがさがった!");
                target.Arank -= 1;
                check.CheckRankState(target);
            }
        }
    }
}
