using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;
using System.Collections;

namespace BattleOfConsole.Skills
{
    internal class QuiverDance : Skill
    {
        public QuiverDance() :base("ちょうのまい", Type.Types.Bug, Kind.change, 0, 20, 100,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon, Pokemon target,Weather.Weathers weather)
        {
            base.ChangeSkillEffect(pokemon, target,weather);
            {
                Check check = new Check();
                pokemon.Crank += 1;
                pokemon.Drank += 1;
                pokemon.Srank += 1;
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
                if (pokemon.Srank == 6)
                {
                    Console.WriteLine($"{pokemon.Name}のすばやさはもうあがらない!");
                }
                else
                {
                    Console.WriteLine($"{pokemon.Name}のすばやさがあがった!");
                }
            }
        }
    }
}
