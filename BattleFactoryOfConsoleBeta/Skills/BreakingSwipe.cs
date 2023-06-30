using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class LowSweep:Skill
    {
        public LowSweep() : base("ローキック", Type.Types.Fight, Kind.attack, 65, 15, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            if(target.Abilities.Name == "クリアボディ") 
            {
                Console.WriteLine($"{target.Name}のすばやさはクリアボディでさがらない!");
            }
            else if(target.Srank == -6)
            {
                Console.WriteLine($"{target.Name}のすばやさはもうさがらない!");
            }
            else 
            {
                Console.WriteLine($"{target.Name}のすばやさがさがった!");
                target.Srank -= 1;
                check.CheckRankState(target);
            }
        }
    }
}
