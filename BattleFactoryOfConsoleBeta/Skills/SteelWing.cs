using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class SteelWing:Skill
    {
        public SteelWing() : base("はがねのつばさ", Type.Types.Metal, Kind.attack, 70, 25, 90,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            Random r = new Random();

            if ((pokemon.Brank != 6) && (r.Next(1,101) <= 10))
            {
                Console.WriteLine($"{pokemon.Name}のぼうぎょがあがった!");
                pokemon.Brank += 1;
                check.CheckRankState(pokemon);
            }

        }
    }
}
