using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class Liquidation : Skill
    {
        public Liquidation() : base("アクアブレイク", Type.Types.Water, Kind.attack, 85, 10, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Check check = new Check();
            Random r = new Random();
            if (target.Brank != -6 && (r.Next(1, 101) <= 20) && (target.Abilities.Name == "クリアボディ"))
            {
                target.Brank -= 1;
                check.CheckRankState(target);
                Console.WriteLine($"{target.Name}のぼうぎょがさがった!");
            }

        }

    }
}
