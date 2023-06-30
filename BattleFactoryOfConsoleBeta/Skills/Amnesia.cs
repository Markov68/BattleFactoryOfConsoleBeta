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
    internal class Amnesia : Skill
    {
        public Amnesia() :base("ドわすれ", Type.Types.Psy, Kind.change, 0, 20, 100,0,false) 
        {
        }

        public override void ChangeSkillEffect(Pokemon pokemon ,Pokemon target,Weather.Weathers weather) 
        {
            Check check = new Check();
            if (pokemon.Drank == 6) 
            {
                Console.WriteLine($"{pokemon.Name}のとくぼうはもうあがらない!");
            }
            else if (pokemon.Drank == 5) 
            {
                Console.WriteLine($"{pokemon.Name}のとくぼうがあがった!");
                pokemon.Drank += 1;
                check.CheckRankState(pokemon);
            }
            else 
            {
                Console.WriteLine($"{pokemon.Name}のとくぼうがぐーんとあがった!");
                pokemon.Drank += 2;
                check.CheckRankState(pokemon);
            }
        }
    }
}
