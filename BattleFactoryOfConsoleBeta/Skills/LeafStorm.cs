﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class LeafStorm : Skill
    {
        public LeafStorm() : base("リーフストーム", Type.Types.Leaf, Kind.cattack, 130, 5, 90, 0, false)
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            pokemon.Crank -= 2;
            check.CheckRankState(pokemon);
            if (pokemon.Abilities.Name == "クリアボディ")
            {
                Console.WriteLine("クリアボディのこうかでのうりょくがさがらない!");
            }
            else if (pokemon.Crank == -6)
            {
                Console.WriteLine($"{pokemon.Name}のとくこうはもうさがらない!");
            }
            else
            {
                Console.WriteLine($"{pokemon.Name}のとくこうががくっとさがった!");
            }
        }
    }
}
