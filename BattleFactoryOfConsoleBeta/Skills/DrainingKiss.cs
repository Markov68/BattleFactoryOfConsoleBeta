using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfConsole.Skills
{
    internal class DrainingKiss:Skill
    {
        public DrainingKiss() : base("ドレインキッス", Type.Types.Fairy, Kind.cattack, 50, 10, 100,0,true) 
        {
        }

        public override void AfterDamageEffect(Pokemon pokemon, Pokemon target,double damage)
        {
            Check check = new Check();
            pokemon.IH += (int)(damage * 3 / 4);
            Console.WriteLine($"{pokemon.Name}はたいりょくをすいとった!");
            check.CheckIH(pokemon);

        }
    }
}
