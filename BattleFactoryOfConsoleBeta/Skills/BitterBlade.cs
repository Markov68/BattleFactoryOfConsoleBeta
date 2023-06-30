using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class BitterBlade:Skill
    {
        public BitterBlade() : base("むねんのつるぎ", Type.Types.Fire, Kind.attack, 90, 10, 100,0,true) 
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
