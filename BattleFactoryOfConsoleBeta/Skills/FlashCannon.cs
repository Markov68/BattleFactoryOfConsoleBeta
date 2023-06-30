using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class FlashCannon:Skill
    {
        public FlashCannon() : base("ラスターカノン", Type.Types.Metal, Kind.cattack, 80, 10, 100,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Random r = new Random();
            Check check = new Check();

            if (r.Next(1,101) <= 10) 
            {
                target.Drank -= 1;
                check.CheckRankState(target);
                if (target.Abilities.Name == "クリアボディ")
                {
                    Console.WriteLine("クリアボディのこうかでのうりょくがさがらない!");
                }
                else if (target.Drank == -6)
                {
                    Console.WriteLine($"{target.Name}のとくぼうはもうさがらない!");
                }
                else
                {
                    Console.WriteLine($"{target.Name}のとくぼうがさがった!");
                }
            }

        }
    }
}
