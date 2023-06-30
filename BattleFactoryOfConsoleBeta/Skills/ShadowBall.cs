using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class ShadowBall:Skill
    {
        public ShadowBall() : base("シャドーボール", Type.Types.Gohst, Kind.cattack, 80, 15, 100,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            Random r = new Random();
            if(r.Next(1,101)<= 20) 
            {
                if (target.Abilities.Name == "クリアボディ")
                {
                    Console.WriteLine("クリアボディのこうかでのうりょくがさがらない!");
                }
                else if (target.ID !=  -6) 
                {
                    target.Drank -= 1;
                    check.CheckRankState(target);
                    Console.WriteLine($"{target.Name}のとくぼうがさがった!");
                }
                
            }

        }
    }
}
