﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class CalmMind : Skill
    {
        public CalmMind() :base("めいそう", Type.Types.Psy, Kind.change, 0, 20, 100,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                Check check = new Check();
                pokemon.Crank += 1;
                pokemon.Drank += 1;
                check.CheckRankState(pokemon);
                if (pokemon.Crank == 6)
                {
                    Console.WriteLine($"{pokemon.Name}のとくこうはもうあがらない!");
                }
                else
                {
                    Console.WriteLine($"{pokemon.Name}のとくこうがあがった!");
                }
                if (pokemon.Drank == 6)
                {
                    Console.WriteLine($"{pokemon.Name}のとくぼうはもうあがらない!");
                }
                else
                {
                    Console.WriteLine($"{pokemon.Name}のとくぼうがあがった!");
                }
            }
        }
    }
}
