using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class BraveBird:Skill
    {
        public BraveBird() : base("ブレイブバード", Type.Types.Fly, Kind.attack, 120, 15, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Check check = new Check();
            pokemon.IH -= (int)(damage * 0.33);
            Console.WriteLine($"{pokemon.Name}はわざのはんどうをうけた!");
            check.CheckIH(pokemon);
        }
    }
}
