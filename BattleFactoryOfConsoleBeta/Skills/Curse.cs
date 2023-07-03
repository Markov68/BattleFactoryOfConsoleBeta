using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattleOfConsole.Skill;
using System.Xml.Linq;

namespace BattleOfConsole.Skills
{
    internal class Curse : Skill
    {
        public Curse() :base("のろい", Type.Types.Gohst, Kind.change, 0, 10, 100,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon ,Pokemon target,Weather.Weathers weather) 
        {
            if((pokemon.Type1 != Type.Types.Gohst) && (pokemon.Type2 != Type.Types.Gohst)) 
            {
                Check check = new Check();
                pokemon.Arank += 1;
                pokemon.Brank += 1;
                pokemon.Srank -= 1;
                check.CheckRankState(pokemon);
                if (pokemon.Arank == 6)
                {
                    Console.WriteLine($"{pokemon.Name}のこうげきはもうあがらない!");
                }
                else
                {
                    Console.WriteLine($"{pokemon.Name}のこうげきがあがった!");
                }
                if (pokemon.Brank == 6)
                {
                    Console.WriteLine($"{pokemon.Name}のぼうぎょはもうあがらない!");
                }
                else
                {
                    Console.WriteLine($"{pokemon.Name}のぼうぎょがあがった!");
                }
                if (pokemon.Srank == -6)
                {
                    Console.WriteLine($"{pokemon.Name}のすばやさはもうさがらない!");
                }
                else
                {
                    Console.WriteLine($"{pokemon.Name}のすばやさがさがった!");
                }
            }
            
        }
    }
}
