using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class EarthPower : Skill
    {
        public EarthPower() : base("だいちのちから", Type.Types.Grand, Kind.cattack, 90, 10, 100,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            Random r = new Random();
            if (target.Abilities.Name == "クリアボディ")
            {
                Console.WriteLine("クリアボディのこうかでのうりょくがさがらない!");
            }
            else if (target.Drank != -6 && (r.Next(1,101) <= 10))
            {
                target.Drank -= 1;
                check.CheckRankState(target);
                Console.WriteLine($"{target.Name}のとくぼうがさがった!");
            }

        }
    }
}
