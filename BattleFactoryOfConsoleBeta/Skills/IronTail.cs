using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class IronTail:Skill
    {
        public IronTail() : base("アイアンテール", Type.Types.Metal, Kind.attack, 100, 15, 75,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            Random r = new Random();
            if((r.Next(1,101) <= 30) && (target.Brank != -6))
            {
                Console.WriteLine($"{target.Name}のぼうぎょがさがった!");
                target.Brank -= 1;
                check.CheckRankState(target);
            }
        }
    }
}
