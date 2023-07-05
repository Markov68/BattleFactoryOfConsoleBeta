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
    internal class NastyPlot : Skill
    {
        public NastyPlot() :base("わるだくみ", Type.Types.Dark, Kind.change, 0, 20, 100,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon ,Pokemon target,Weather.Weathers weather) 
        {
            Check check = new Check();
            if (pokemon.Crank == 6) 
            {
                Console.WriteLine($"{pokemon.Name}のとくこうはもうあがらない!");
            }
            else if (pokemon.Crank == 5) 
            {
                Console.WriteLine($"{pokemon.Name}のとくこうがあがった!");
                pokemon.Crank += 1;
                check.CheckRankState(pokemon);
            }
            else 
            {
                Console.WriteLine($"{pokemon.Name}のとくこうがぐーんとあがった!");
                pokemon.Crank += 2;
                check.CheckRankState(pokemon);
            }
        }
    }
}
