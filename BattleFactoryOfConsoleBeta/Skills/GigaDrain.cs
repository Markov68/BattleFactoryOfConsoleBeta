using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class GigaDrain:Skill
    {
        public GigaDrain() : base("ギガドレイン", Type.Types.Leaf, Kind.cattack, 75, 10, 100,0,false) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target, double damage)
        {
            Check check = new Check();
            pokemon.IH += (int)(damage / 2);
            Console.WriteLine($"{pokemon.Name}はたいりょくをすいとった!");
            check.CheckIH(pokemon);
        }
    }
}
