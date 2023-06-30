using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class MysticalFire:Skill
    {
        public MysticalFire() : base("マジカルフレイム", Type.Types.Fire, Kind.cattack, 75, 10, 100,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            target.Crank -= 1;
            check.CheckRankState(target);
            if (target.Abilities.Name == "クリアボディ")
            {
                Console.WriteLine("クリアボディのこうかでのうりょくがさがらない!");
            }
            else if (target.Crank == -6)
            {
                Console.WriteLine($"{target.Name}のとくこうはもうさがらない!");
            }
            else
            {
                Console.WriteLine($"{target.Name}のとくこうがさがった!");
            }

        }
    }
}
