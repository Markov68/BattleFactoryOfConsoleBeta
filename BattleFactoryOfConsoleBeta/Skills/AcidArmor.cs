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
    internal class AcidArmor : Skill
    {
        public AcidArmor() :base("とける", Type.Types.Poison, Kind.change, 0, 20, 100,0,false) { }

        public override void ChangeSkillEffect(Pokemon pokemon ,Pokemon target,Weather.Weathers weather) 
        {
            Check check = new Check();
            if (pokemon.Brank == 6) 
            {
                Console.WriteLine($"{pokemon.Name}のぼうぎょはもうあがらない!");
            }
            else if (pokemon.Brank == 5) 
            {
                Console.WriteLine($"{pokemon.Name}のぼうぎょがあがった!");
                pokemon.Brank += 1;
                check.CheckRankState(pokemon);
            }
            else 
            {
                Console.WriteLine($"{pokemon.Name}のぼうぎょがぐーんとあがった!");
                pokemon.Brank += 2;
                check.CheckRankState(pokemon);
            }
        }
    }
}
