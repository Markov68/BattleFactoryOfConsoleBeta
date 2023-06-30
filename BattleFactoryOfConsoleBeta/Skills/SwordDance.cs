using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;
using System.ComponentModel.Design;

namespace BattleOfConsole.Skills
{
    internal class SwordDance : Skill
    {
        public SwordDance() :base("つるぎのまい", Type.Types.Nomal, Kind.change, 0, 20, 100,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon ,Pokemon target,Weather.Weathers weather) 
        {
            Check check = new Check();
            if (pokemon.Arank == 6) 
            {
                Console.WriteLine($"{pokemon.Name}のこうげきはもうあがらない!");
            }
            else if (pokemon.Arank == 5) 
            {
                Console.WriteLine($"{pokemon.Name}のこうげきがあがった!");
                pokemon.Arank += 1;
                check.CheckRankState(pokemon);
            }
            else 
            {
                Console.WriteLine($"{pokemon.Name}のこうげきがぐーんとあがった!");
                pokemon.Arank += 2;
                check.CheckRankState(pokemon);
            }
        }
    }
}
