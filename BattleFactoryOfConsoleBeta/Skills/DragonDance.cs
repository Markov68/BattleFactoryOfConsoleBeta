using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class DragonDance : Skill
    {
        public DragonDance() :base("りゅうのまい", Type.Types.Dragon, Kind.change, 0, 20, 100,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon ,Pokemon target,Weather.Weathers weather) 
        {
            Check check = new Check();
            pokemon.Arank += 1;
            pokemon.Srank += 1;
            check.CheckRankState(pokemon);
            if (pokemon.Arank == 6) 
            {
                Console.WriteLine($"{pokemon.Name}のこうげきはもうあがらない!");
            }
            else 
            {
                Console.WriteLine($"{pokemon.Name}のこうげきがあがった!");
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
