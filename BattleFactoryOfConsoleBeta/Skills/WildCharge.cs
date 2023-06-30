using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class WildCharge:Skill
    {
        public WildCharge() : base("ワイルドボルト", Type.Types.Elec, Kind.attack, 90, 15, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Check check = new Check();
            pokemon.IH -= (int)(damage / 4);
            Console.WriteLine($"{pokemon.Name}はわざのはんどうをうけた!");
            check.CheckIH(pokemon);

        }
    }
}
