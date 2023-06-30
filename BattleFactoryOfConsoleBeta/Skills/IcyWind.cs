using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class IcyWind : Skill
    {
        public IcyWind() : base("こごえるかぜ", Type.Types.Ice, Kind.cattack, 55, 15, 95, 0, false)
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Check check = new Check();
            if (target.Abilities.Name == "クリアボディ")
            {
                Console.WriteLine($"{target.Name}のすばやさはクリアボディでさがらない!");
            }
            else if (target.Srank == -6)
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
